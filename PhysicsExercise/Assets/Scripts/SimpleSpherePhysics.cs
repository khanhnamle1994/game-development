using UnityEngine;
using System.Collections;

public class SimpleSpherePhysics : MonoBehaviour {
	
	// Units in unity is assumed to be in meters

	const float gravity = 9.81f; // acceleration m/s2 (meter/second)

	public Vector3 velocity = Vector3.zero; // meter/second

	public float radius;

	// Use this for initialization
	void Start () {
		radius = transform.localScale.x*0.5f; // assume uniform scale
	}

	void AddGravity(){
		velocity = new Vector3 (velocity.x, velocity.y - (Time.fixedDeltaTime * gravity), velocity.z);
	}

	void UpdatePositionBasedOnVelocity(){
		transform.position += velocity * Time.fixedDeltaTime;
	}

	void FixedUpdate(){
		AddGravity ();
		UpdatePositionBasedOnVelocity ();
	}
}
