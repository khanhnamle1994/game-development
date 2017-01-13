using UnityEngine;
using System.Collections;

public class StartLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey || Input.GetMouseButton(0) || Input.touches.Length>0){
			Application.LoadLevel (1);
		}
	}
}
