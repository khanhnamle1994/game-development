using UnityEngine;
using System.Collections;

public class RotateBox : MonoBehaviour {

	GameObject rotatingBox;

	// Use this for initialization
	void Start () {
		rotatingBox = GameObject.Find ("BoxRotating");
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			StartCoroutine (RotateLerp ());
		}
	}

	IEnumerator RotateLerp () {
		float time = 0;
		float totalTime = 3;
		Vector3 initAngle = rotatingBox.transform.localEulerAngles;
		Vector3 targetAngle = initAngle;
		targetAngle.z = -20;
		while (time < totalTime) {
			rotatingBox.transform.localEulerAngles = Vector3.Lerp (initAngle, targetAngle, time / totalTime);
			yield return null; // wait for one frame
			time = time + Time.deltaTime;
		}
		yield return null;
	}
}
