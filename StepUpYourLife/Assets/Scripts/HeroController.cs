using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {

	public Camera camera;
	Light[] lights;

	public Collider level;
	public Transform debugBall;
	Animator anim;

	public SpriteRenderer[] sprites;

	public bool wheelChair = false;

	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

		lights = GetComponentsInChildren<Light> ();

		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			foreach (var l in lights) {
				l.enabled = true;
			}


			anim.SetBool ("lightEnabled", true);
		}
		if (Input.GetMouseButtonUp (0)) {
			foreach (var l in lights) {
				l.enabled = false;
			}


			anim.SetBool ("lightEnabled", false);
		}
		if (Input.GetMouseButton (0)) {
			var pos = Input.mousePosition;
			var cameraRay = camera.ScreenPointToRay (pos);
			RaycastHit hit = new RaycastHit ();
			if (level.Raycast (cameraRay, out hit, float.MaxValue)) {
				Vector3 clickPointInWorldspace = hit.point;
				GetComponent<NavMeshAgent> ().destination = clickPointInWorldspace;
			}
		}
		if (agent) {
			var path = agent.path;
			if (path.status == NavMeshPathStatus.PathComplete) {
				for (int i = 1; i < path.corners.Length; i++) {
					Debug.DrawLine (path.corners [i - 1], path.corners [i]);
				}
			}
		}
	}

	public bool GetWheelChair(){
		if (wheelChair) {
			return false;
		}
		wheelChair = true;
		sprites [0].enabled = false;
		sprites [1].enabled = true;
		GetComponent<NavMeshAgent> ().speed *= 2;
		return true;
	}
}
