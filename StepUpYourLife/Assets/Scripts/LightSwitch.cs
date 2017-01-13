using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {

	Light[] lights;

	// Use this for initialization
	void Start () {
		lights = GetComponentsInChildren<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		foreach (var l in lights) {
			l.enabled = true;
		}

	}

	void OnTriggerExit(Collider col){
		foreach (var l in lights) {
			l.enabled = false;
		}
	}
}
