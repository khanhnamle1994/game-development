using UnityEngine;
using System.Collections;

public class BombDrop : MonoBehaviour {

	public GameObject bomb;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
			bomb.GetComponent<Rigidbody2D> ().isKinematic = false;
		}
	}
}
