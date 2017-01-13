using UnityEngine;
using System.Collections;

public class PickUpCheese : MonoBehaviour {

	GameScore score;

	// Use this for initialization
	void Start () {
		score = GameObject.Find ("ScoreText").GetComponent<GameScore> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
			score.Increment ();
		}
	}
}
