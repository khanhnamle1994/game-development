using UnityEngine;
using System.Collections;

public class RaycastScript : MonoBehaviour {

	public GameObject other;
	public RaycastHit[] oldframe;
	public RaycastHit[] currentframe;
	public Material red;

	void Start() {
		red = gameObject.transform.GetComponent<Renderer> ().material;
	}

	void ColorAllObjectsBetweenThisAndOther (){
		//the old frame is one frame behind the current frame
		oldframe = currentframe;
		currentframe = Physics.SphereCastAll (gameObject.transform.position, transform.GetComponent<SphereCollider> ().radius, 
			other.transform.position - gameObject.transform.position,
			Vector3.Distance (other.transform.position, gameObject.transform.position));

		// Define an array that contains all the changes of color between old and current frame
		ArrayList change = new ArrayList();

		for (int i = 0; i < currentframe.Length; i++) {
			currentframe [i].transform.GetComponent<Renderer> ().material = red;
			change.Add (currentframe [i].collider.gameObject);
		}

		if (oldframe != null) {
			for (int i = 0; i < oldframe.Length; i++) {
				if (!change.Contains (oldframe [i].collider.gameObject))
					oldframe [i].transform.GetComponent<Renderer> ().material.color = Color.black;
			}
		}
	}

	// When an object is between this and other it must be red
	// Otherwise it must be its initial color.
	// Note that you must use a spherecast with the 
	void Update () {
		ColorAllObjectsBetweenThisAndOther ();
	}
}
