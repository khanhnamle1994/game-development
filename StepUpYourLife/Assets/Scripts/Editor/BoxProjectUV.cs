using UnityEngine;
using UnityEditor;
using System.Collections;

public class BoxProjectUV : MonoBehaviour {

	[MenuItem ("Game/BoxProjectUV")]
	// Use this for initialization
	public static void Randomize () {
		//GameObject go = Selection.activeGameObject;
		foreach (GameObject go in GameObject.FindGameObjectsWithTag ("Wall")) {
			MeshFilter mf = go.GetComponent<MeshFilter> ();
			var oldMesh = mf.sharedMesh;
			var newMesh = new Mesh ();
			newMesh.vertices = oldMesh.vertices;
			newMesh.normals = oldMesh.normals;
			newMesh.normals = oldMesh.normals;
			newMesh.bounds = oldMesh.bounds;
			var uvs = new Vector2[oldMesh.uv.Length];
			for (int i = 0; i < uvs.Length; i++) {
				var worldSpacePos = go.transform.TransformPoint (newMesh.vertices[i]);
				uvs [i] = new Vector2 (worldSpacePos.x+worldSpacePos.z, worldSpacePos.y+worldSpacePos.z);
			}
			newMesh.uv = uvs;
			newMesh.triangles = oldMesh.triangles;
			newMesh.name = oldMesh.name + "_box_projected_uv";
			mf.mesh = newMesh;

		}
	}

	[MenuItem ("Game/SetWallMaterial")]
	// Use this for initialization
	public static void Mat () {
		//GameObject go = Selection.activeGameObject;
		foreach (GameObject go in GameObject.FindGameObjectsWithTag ("Wall")) {
			go.GetComponent<MeshRenderer>().material = (Material)AssetDatabase.LoadAssetAtPath("Assets/Materials/Wall.mat", typeof(Material));
			go.GetComponent<MeshRenderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.TwoSided;
		}
	}
}
