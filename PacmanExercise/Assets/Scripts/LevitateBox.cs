using UnityEngine;
using System.Collections;

public class LevitateBox : MonoBehaviour {

	GameObject levitatingBox;

	// Use this for initialization
	void Start () {
		levitatingBox = GameObject.Find ("BoxPlatform");
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			StartCoroutine (LiftLerp ());
		}
	}

	IEnumerator LiftLerp () {
		float time = 0;
		float totalTime = 5;
		Vector3 initPos = levitatingBox.transform.position;
		Vector3 targetPos = initPos + new Vector3 (0, 2.14f, 0);
		while (time < totalTime) {
			levitatingBox.transform.position = Vector3.Lerp (initPos, targetPos, time / totalTime);
			yield return null; // wait for one frame
			time = time + Time.deltaTime;
		}
		yield return null;
	}
}
