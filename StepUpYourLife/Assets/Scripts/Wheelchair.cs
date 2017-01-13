using UnityEngine;
using System.Collections;

public class Wheelchair : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			if (col.GetComponent<HeroController> ().GetWheelChair ()) {
				Destroy (gameObject);
			} else {
				var obstacle = gameObject.AddComponent<NavMeshObstacle> ();

			}
		}
	}
}
