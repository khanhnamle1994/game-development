using UnityEngine;
using System.Collections;

public class WinnerScript : MonoBehaviour {

	public bool win = false;
	public SpriteRenderer winSprite;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag.Equals ("Player")) {
			win = true;
			winSprite.enabled = true;
		} 
	}

	void OnGUI(){
		if (win) {
			if (GUI.Button(new Rect(0,50,200,50), "Restart")){
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
