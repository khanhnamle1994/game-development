using UnityEngine;
using System.Collections;

public class CameraMotion : MonoBehaviour {

	public float speed = 1;
	float radius;

	void Start(){
		radius = transform.position.magnitude;
	}
	
	// Rotates around 0,0,0
	void Update () {
		transform.position = new Vector3 (Mathf.Sin(Time.time*speed),Mathf.Cos(Time.time*speed*1.5f),Mathf.Cos(Time.time*speed)) * radius;
		transform.LookAt (Vector3.zero);
	}
}
