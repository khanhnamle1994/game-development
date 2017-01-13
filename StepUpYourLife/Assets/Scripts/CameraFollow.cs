using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform target;

	Vector3 velocity;

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		var pos = target.position;    
		pos.y = transform.position.y;
		transform.position = Vector3.SmoothDamp (transform.position, pos, ref velocity, Time.deltaTime*speed);
	}
}
