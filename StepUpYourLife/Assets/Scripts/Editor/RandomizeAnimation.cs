using UnityEngine;
using UnityEditor;
using System.Collections;

public class RandomizeAnimation : MonoBehaviour {

	[MenuItem ("Game/RandomizeAnimation")]
	// Use this for initialization
	public static void Randomize () {
		/*var selectedObject = Selection.activeObject;
		AnimationClip animationClip = selectedObject as AnimationClip;
		if (!animationClip) {
			Debug.LogError ("");
			return;
		}

		int size = 10;
		Keyframe[] keys = new Keyframe[size];
		float fps = 60;
		for (int i = 0; i < size; i++) {
			keys [i] = new Keyframe (i/fps, Random.);
		}
		AnimationCurve curve = new AnimationCurve ();*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
