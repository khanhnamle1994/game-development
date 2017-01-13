using UnityEngine;
using System.Collections;

public class ExplodeBox : MonoBehaviour {

    public Rigidbody2D[] nearbyObjects;

    public GameObject explosion;

    // Based on http://forum.unity3d.com/threads/need-rigidbody2d-addexplosionforce.212173/
    public void AddExplosionForce(Rigidbody2D body, float explosionForce, float explosionRadius)
    {
        Vector3 explosionPosition = transform.position;
        var dir = (body.transform.position - explosionPosition);
        float wearoff = 1 - (dir.magnitude / explosionRadius);
        body.AddForce(dir.normalized * explosionForce * wearoff);
    }

	public void OnCollisonEnter2D (Collision2D coll) {
		RaycastHit2D[] boxes;
		if (coll.gameObject.name == "Bird") {
			boxes = Physics2D.CircleCastAll (coll.transform.position, 100, new Vector2 (0, 0));
			foreach (RaycastHit2D b in boxes) {
				GameObject box = b.collider.gameObject;
				if (box.GetComponent<Rigidbody2D> () != null) {
					AddExplosionForce (b.collider.gameObject.GetComponent<Rigidbody2D> (), 100, 50);
					Instantiate (explosion, gameObject.transform.position, Quaternion.identity);
					Destroy (gameObject);
				}
			}
		}
	}
}
