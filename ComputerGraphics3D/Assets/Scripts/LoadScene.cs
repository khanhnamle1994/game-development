using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadScene1(){
		SceneManager.LoadScene(1);
	}
	public void LoadScene2(){
		SceneManager.LoadScene(2);
	}
	public void LoadScene3(){
		SceneManager.LoadScene(3);
	}
	public void LoadScene4(){
		SceneManager.LoadScene(4);
	}
}
