using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	Animator anim;

	int numberOfPeopleInTrigger = 0;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "Enemy") {
			numberOfPeopleInTrigger++;
			anim.SetBool ("open", true);
		}

	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "Player" || col.gameObject.tag == "Enemy") {
			numberOfPeopleInTrigger++;

		}
		if (numberOfPeopleInTrigger==0) {
			anim.SetBool ("open", false);
		}
	}
}
