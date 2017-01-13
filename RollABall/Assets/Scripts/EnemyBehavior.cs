using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour {

	bool hit;
	GUIText winText;

	// Use this for initialization
	void Start () {
		hit = false;
		winText = FindObjectsOfType<GUIText> () [1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			Vector3 move = other.transform.position - gameObject.transform.position;
			gameObject.GetComponent<Rigidbody> ().AddForce (move * 50);
		}
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Player") {
			hit = true;
			StartCoroutine (DestroyPlayer ());
		}
	}

	IEnumerator DestroyPlayer()
	{
		winText.text = "You died!";
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			if (hit) {
				Debug.Log ("It's gone");
				hit = false;
			}
			else
				Debug.Log ("Nothing happens");
			Vector3 move = other.transform.position - gameObject.transform.position;
			gameObject.GetComponent<Rigidbody> ().AddForce (move * 30);
		}
	}
}
