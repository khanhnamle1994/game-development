using UnityEngine;
using System.Collections;

public class ColorTriangle1 : MonoBehaviour {
	

	public Material vertexColorMaterial;


	public Mesh CreateMesh()
	{
		Mesh mesh = new Mesh();
		Vector3[] origVert = new Vector3[]{
			new Vector3(0,0,0),
			new Vector3(0,1,0),
			new Vector3(1,1,0),
		};
		Color[] origCol = new Color[]{
			new Color(1,0,0),
			new Color(0,1,0),
			new Color(0,0,1),
		};
		int[] origTri = new int[]{
			0,1,2
		};


		ArrayList vertices = new ArrayList();
		for (int i = 0; i < 360; i += 45) { 
			foreach (Vector3 v in origVert) {
				Quaternion rotation = Quaternion.Euler(0, 0, i);
				vertices.Add(rotation * v);
			}

		}
		//object[] temp = vertices.ToArray();
		//mesh.vertices = Array.ConvertAll(temp, (Object => (Vector3)Object));
		var col = new Color[mesh.vertices.Length];
		var tri = new int[mesh.vertices.Length];

		for (int i = 0; i < mesh.vertices.Length; i += 3) {
			for (int j = 0; j < 3; j++) {
				col[i+j] = origCol[j];
				tri[i+j] = origTri[i+j];
			}
		}

		mesh.triangles = tri;
		mesh.colors = col;

		mesh.RecalculateBounds();
		mesh.RecalculateNormals();

		return mesh;
	}


	// Use this for initialization
	void Start () {
		MeshFilter meshFilter = gameObject.GetComponent<MeshFilter> ();
		if (meshFilter == null) {
			meshFilter = gameObject.AddComponent<MeshFilter> ();
		}
		meshFilter.mesh = CreateMesh();
		MeshRenderer renderer = gameObject.GetComponent<MeshRenderer> ();
		if (renderer == null) {
			renderer = gameObject.AddComponent<MeshRenderer> ();
		}
		renderer.material = vertexColorMaterial;
	}
}
