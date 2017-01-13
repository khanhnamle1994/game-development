// Patrol.cs
using UnityEngine;
using System.Collections;


public class Patrol : MonoBehaviour {

	public Transform[] points;
	private NavMeshAgent agent;

	public HeroController controller;

	void Start () {
		agent = GetComponent<NavMeshAgent>();
		controller = FindObjectOfType<HeroController> ();

		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		agent.autoBraking = false;

	}


	void Update () {
		
	}
}