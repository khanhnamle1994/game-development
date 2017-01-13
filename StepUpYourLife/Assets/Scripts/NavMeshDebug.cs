using UnityEngine;
using System.Collections;

public class NavMeshDebug : MonoBehaviour {
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (agent) {
			var path = agent.path;
			if (path.status == NavMeshPathStatus.PathComplete) {
				for (int i = 1; i < path.corners.Length; i++) {
					Debug.DrawLine (path.corners [i - 1], path.corners [i]);
				}
			}
		}
	}
}
