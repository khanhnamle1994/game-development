using UnityEngine;
using System.Collections;

public class LaunchScript : MonoBehaviour {

    public Collider2D stand;

    Rigidbody2D rb;

    Vector3 fromPointMouse;
    Vector3 initialPosition;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D> ();
        initialPosition = rb.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() {
        stand.isTrigger = true; // disable collision
        fromPointMouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        rb.isKinematic = true;

    }

    void OnMouseDrag() {
        var toPointMouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        var delta = (toPointMouse - fromPointMouse);
        Debug.Log(delta+" "+toPointMouse);
        rb.position = initialPosition + delta;
    }

    void OnMouseUp() {
        rb.isKinematic = false;
		rb.AddForce (new Vector2 (initialPosition.x - rb.position.x, initialPosition.y - rb.position.y) * 500);
    }
}
