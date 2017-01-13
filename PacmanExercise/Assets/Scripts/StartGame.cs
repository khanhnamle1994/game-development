using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	Vector3 newPos;

	// Use this for initialization
	void Start () {
		newPos = transform.position - new Vector3 (1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI () {
		if (GUI.Button (new Rect (0, 0, 200, 50), "Start")) {
			//Make button disappear
			StartCoroutine (SpringLerp ());
		}
	}

	IEnumerator SpringLerp () {
		float time = 0;
		float totalTime = 0.5f;
		Vector3 initPos = transform.position;
		Vector3 targetPos = newPos;
		while (time < totalTime) {
			transform.position = Vector3.Lerp (initPos, targetPos, time / totalTime);
			yield return null; // wait for one frame
			time = time + Time.deltaTime;
		}
		yield return null;
	}
}
