using UnityEngine;
using System.Collections;

public class GroundCollider : MonoBehaviour {

	public SimpleSpherePhysics[] spheresInScene;

	// Use this for initialization
	void Start () {
		spheresInScene = FindObjectsOfType<SimpleSpherePhysics> ();
	}

	void FixedUpdate(){
		for (int i = 0; i < spheresInScene.Length; i++) {
			if (spheresInScene [i].transform.position.y - spheresInScene [i].radius < gameObject.transform.position.y) {
				spheresInScene [i].velocity.y = -(spheresInScene [i].velocity.y);
			}
		}
	}
}
