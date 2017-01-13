using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pyramid : MonoBehaviour {
	

	public Material cubeMaterial;


	public Mesh CreateMesh(){
		Mesh mesh = new Mesh ();
		mesh.vertices = new Vector3[]{
			new Vector3(-0.5f,-0.5f,-0.5f),
			new Vector3(-0.5f,-0.5f,0.5f),
			new Vector3(0.5f,-0.5f,0.5f),
			new Vector3(0.5f,-0.5f,-0.5f),
			new Vector3(0f,0.5f,0f)
		};
		mesh.triangles = new int[]{ 
			0,1,2,
			2,3,0,
			4,1,0,
			4,2,1,
			4,3,2,
			4,0,3
		};
		mesh.RecalculateBounds ();
		mesh.RecalculateNormals ();
		mesh.Optimize ();
		return mesh;
	}

	// Use this for initialization
	void Start () {
		MeshFilter meshFilter = gameObject.GetComponent<MeshFilter> ();
		if (meshFilter == null) {
			meshFilter = gameObject.AddComponent<MeshFilter> ();
		}
		meshFilter.mesh = CreateMesh();
		Debug.Log ("Mesh info vertices: "+meshFilter.sharedMesh.vertices.Length+" triangles "+(meshFilter.sharedMesh.triangles.Length/3));
		MeshRenderer renderer = gameObject.GetComponent<MeshRenderer> ();
		if (renderer == null) {
			renderer = gameObject.AddComponent<MeshRenderer> ();
		}
		renderer.material = cubeMaterial;
	}
}
