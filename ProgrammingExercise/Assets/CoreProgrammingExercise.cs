using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Implement the methods. You are not allowed to change the method signature.
// You are welcome to add additional new methods and fields to the class.
// Also make sure that you test your code (either the Start method or other classes)
public class CoreProgrammingExercise : MonoBehaviour {

	public delegate float MathFunction (double x);

	void Start () {
		WriteStudentNameToConsole ();
		GetScreenWindowPixels ();
		StringFun ();
		ReadMeansDouble ();
		CreateSinFn ();
		DoubleTheSize ();
		LookAt ();
		AddVectors ();
		DistanceBetweenObjects ();
		GetAllFooComponentsInParents ();
		AllFooInSceneSortedByValue ();
		DisableChildFooByName ();
		MoveToPosition ();
		DestroyComponentsExceptTransform ();
		SmoothColorChange ();
	}


	// Write your full name to the Unity console
	public void WriteStudentNameToConsole(){
		Debug.Log ("James");
	}

	// Return the number of pixels in the screen (game) window
	// Hint use the Screen class
	public int GetScreenWindowPixels(){
		return Screen.width & Screen.height;
	}

	// Return the sum of all the digits of s
	// examples
	// StringFun("ab123") == 6
	// StringFun("1ab1") == 2
	// StringFun("ab") == 0
	public int StringFun(string s){
		for (int i; i < s.Length){
			int count;
			count = count + 1;
		}
		return count;
	}

	int someValue;
	// chance the field to a property
	// the setter method should store the value in the field someValue
	// the getter method should return someValue*2
	// Important: the name of the property must be ReadMeansDouble
	public int ReadMeansDouble
	{
		set(ReadMeansDouble(someValue));
		get(someValue * 2);
	}

	// Create a function which takes a input (double) and return its sine values (as float)
	// Note you must use the Mathf.Sin()
	public float CreateSinFn(double input){
		return float(Mathf(input));
	}

	// Double the scale of g
	public void DoubleTheSize(GameObject g){
		g.transform.localScale = new Vector3 (2.0f, 2.0f, 2.0f);
	}

	// Rotate the GameObject player to face PointOfInterest using the LookAt method
	public void LookAt(GameObject player, GameObject pointOfInterest){
		player.transform.LookAt (pointOfInterest);
	}

	// Add the three vectors. Assume that the missing component is zero 
	// (e.g. the z value of vector 2)
	public Vector4 AddVectors(Vector2 v2, Vector3 v3, Vector4 v4){
		Vector4 vA = new Vector4 (v2.x, v2.y, 0, 0);
		Vector4 vB = new Vector4 (v3.x, v3.y, v3.z, 0);
		v4 = vA + vB;
		return v4;
	}

	// Return the distance between two game objects
	public float DistanceBetweenObjects(GameObject g1, GameObject g2){
		float distance = (float)Mathf.Sqrt (Mathf.Pow (g1.position.x - g2.x, 2) + Mathf.Pow (g1.y - g2.y, 2) + Mathf.Pow (g1.z - g2.z, 2));
		return distance;
	}

	// Return all Foo components found in parent objects. If g1 has a Foo component, it should not be returned.
	public Foo[] GetAllFooComponentsInParents(GameObject g1){
		foreach(Transform 
		return null;
	}

	// Return a list of all Foo objects in the scene. 
	// The list must sorted in acending order
	public List<Foo> AllFooInSceneSortedByValue(){
		// TODO implement
		return null;
	}

	// Disable any Foo component which is a child object to go where the
	// name of the gameobject equals the string withName
	public void DisableChildFooByName(GameObject go, string withName){
		// TODO implement
	}

	// Move the gameobject g to the given position over noFrames
	// example if original position is (0,0,0), destPosition is (3,0,0) and noFrames = 3
	// then the following movement should occur:
	// current frame: (1,0,0)
	// next frame: (2,0,0)
	// next frame: (3,0,0)
	public IEnumerator MoveToPosition(GameObject g, Vector3 destPosition, int noFrames){
		float timeSinceStarted = 0f;
		while (true) {
			timeSinceStarted += Time.deltaTime;
			g.transform.position = Vector3.Lerp (g.transform.position, destPosition, timeSinceStarted);

			if (g.transform.position == destPosition) {
				yield break;
			}

			yield return null;
		}
	}

	// Destroy all components in gameobject go, except its transform component
	public void DestroyComponentsExceptTransform(GameObject go){
		var components = go.GetComponents (typeof(Component));
		for (var comp : Component in components) {
			if(!(comp instanceof Transform)) {
				Destroy(comp);
			}
		}
	}

	// Update the material color gradually to destColor over noSeconds
	// (hint: Use Color.Lerp())
	public IEnumerator SmoothColorChange (Material mat, Color destCol, float noSeconds){
		// TODO implement
		yield return null;
	}
}
