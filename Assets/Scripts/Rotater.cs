using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {
	//Second method to rotate : private Transform tf;
	// Use this for initialization
	void Start () {
		//Second method to rotate :  tf = GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (20, 40, 60) * Time.deltaTime);
		
	}
	/*void FixedUpdate(){
		tf.Rotate (new Vector3 (3, 3, 3)); // second method to rotate
	}*/
}
