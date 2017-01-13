using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevel1(){
		Application.LoadLevel (1);
	}

	public void LoadLevel2(){
		Application.LoadLevel (2);
	}

	public void LoadLevel3(){
		Application.LoadLevel (3);
	}

    public void LoadLevel4(){
        Application.LoadLevel (4);
    }
}
