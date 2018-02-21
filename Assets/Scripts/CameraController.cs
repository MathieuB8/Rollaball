using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
		player.GetComponents<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
	}
	void LateUpdate(){ // at the end, so we are sure all the objects have moved, everything happened before moving camera
		transform.position = player.transform.position + offset;
	}
}
