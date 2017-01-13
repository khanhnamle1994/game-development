using UnityEngine;
using System.Collections;

public class SimpleController : MonoBehaviour {
	public float speed = 2.0f;

	public KeyCode up;
	public KeyCode down;
	public KeyCode left;
	public KeyCode right;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if (Input.GetKey (up)) {
			pos += Vector3.up * speed*Time.deltaTime;
		}
		if (Input.GetKey (down)) {
			pos += Vector3.down * speed*Time.deltaTime;
		}
		if (Input.GetKey (left)) {
			pos += Vector3.left * speed*Time.deltaTime;
		}
		if (Input.GetKey (right)) {
			pos += Vector3.right * speed*Time.deltaTime;
		}
		transform.position = pos;
	}
}
