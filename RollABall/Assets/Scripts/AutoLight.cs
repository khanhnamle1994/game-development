using UnityEngine;
using System.Collections;

public class AutoLight : MonoBehaviour {

	public float range;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Light> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		range = gameObject.GetComponent<Light> ().range;
		gameObject.GetComponent<SphereCollider> ().radius = range;
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			gameObject.GetComponent<Light> ().enabled = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			gameObject.GetComponent<Light> ().enabled = false;
		}
	}
}
