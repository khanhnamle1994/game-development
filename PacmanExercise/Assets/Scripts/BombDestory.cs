using UnityEngine;
using System.Collections;

public class BombDestory : MonoBehaviour {

	GameObject bang;

	void OnTriggerEnter2D (Collider2D other) {
		gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;
		Destroy (other.gameObject);
		bang = GameObject.Find ("bang");
		Debug.Log (bang.GetComponent<SpriteRenderer> ().ToString ());
		ShowBang ();
		Invoke ("DestroyBang", 2f);
	}

	void ShowBang () {
		bang.GetComponent<SpriteRenderer> ().enabled = true;
	}

	void DestroyBang () {
		Destroy (bang);
		Destroy (gameObject);
	}
}
