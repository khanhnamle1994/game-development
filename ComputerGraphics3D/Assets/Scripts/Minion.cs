using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Minion : MonoBehaviour {

	public Material minionMaterial;

	public Mesh CreateMesh(){
		Mesh mesh = new Mesh ();
		mesh.vertices = new Vector3[]{
			// face 1 (xy plane, z = 0)
			new Vector3(0,0,0),
			new Vector3(1,0,0),
			new Vector3(1,1,0),
			new Vector3(0,1,0),
			// face 2 (zy plane, x = 1)
			new Vector3(1,0,0),
			new Vector3(1,0,1),
			new Vector3(1,1,1),
			new Vector3(1,1,0),
			// face 3 (xy plane, z = 1)
			new Vector3(1,0,1),
			new Vector3(0,0,1),
			new Vector3(0,1,1),
			new Vector3(1,1,1),
			// face 4 (zy plane, x = 0)
			new Vector3(0,0,1),
			new Vector3(0,0,0),
			new Vector3(0,1,0),
			new Vector3(0,1,1),
			// face 5 (zx plane, y = 1)
			new Vector3(0,1,0),
			new Vector3(1,1,0),
			new Vector3(1,1,1),
			new Vector3(0,1,1),
			// face 6 (zx plane, y = 0)
			new Vector3(0,0,0),
			new Vector3(0,0,1),
			new Vector3(1,0,1),
			new Vector3(1,0,0),
		};

		int faces = 6; // 6 faces = 12 triangles

		List<int> triangles = new List<int> ();

		for (int i = 0; i < faces; i++) {
			int ListofTriangles = i * 4;
			triangles.Add (0 + ListofTriangles);
			triangles.Add (2 + ListofTriangles);
			triangles.Add (1 + ListofTriangles);

			triangles.Add (0 + ListofTriangles);
			triangles.Add (3 + ListofTriangles);
			triangles.Add (2 + ListofTriangles);
		}

		mesh.triangles = triangles.ToArray ();

		mesh.uv = new Vector2[]{
			new Vector2(0.33f,0),
			new Vector2(0.33f,1),
			new Vector2(0.67f,1),
			new Vector2(0.67f,0),

			new Vector2(0.67f,0),
			new Vector2(0.67f,1),
			new Vector2(1,1),
			new Vector2(1,0),

			new Vector2(0,0),
			new Vector2(0,0.33f),
			new Vector2(0.33f,0.33f),
			new Vector2(0.33f,0),

			new Vector2(0,0),
			new Vector2(0,0.33f),
			new Vector2(0.33f,0.33f),
			new Vector2(0.33f,0),

			new Vector2(1,0),
			new Vector2(0.67f,0),
			new Vector2(0.67f,1),
			new Vector2(1,1),

			new Vector2(1,0),
			new Vector2(0.67f,0),
			new Vector2(0.67f,1),
			new Vector2(1,1),
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
		renderer.material = minionMaterial;
	}
}
