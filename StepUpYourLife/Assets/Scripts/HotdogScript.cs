using UnityEngine;
using System.Collections;

public class HotdogScript : MonoBehaviour {
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<NavMeshAgent> ().speed *= 2;
			Destroy (gameObject);
		}
	}
}
