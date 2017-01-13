using UnityEngine;
using System.Collections;

public class GameScore : MonoBehaviour {

	int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}

	public void Increment () {
		score++;
		gameObject.GetComponent<TextMesh> ().text = "Score: " + score;
	}

	public void Decrement () {
		score--;
		gameObject.GetComponent<TextMesh> ().text = "Score: " + score;
	}
}
