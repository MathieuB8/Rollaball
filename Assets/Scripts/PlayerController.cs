using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float groundspeed = 10;
	public float jumpspeed = 10;

	public Text countText;
	public Text victoryText;
	private int count;
	private int numberPickUps;

	void updateScore(){
		countText.text = "Count: " + count.ToString();

	}
	void Start(){
		rb = GetComponent<Rigidbody> ();
		victoryText.text = "";
		count = 0;
		numberPickUps = GameObject.FindGameObjectsWithTag ("PickUp").Length;;
		updateScore ();

	}

	void OnTriggerEnter(Collider other){
		//Destroy (other.gameObject);
		if (other.gameObject.CompareTag("PickUp")){
			other.gameObject.SetActive(false);
			count += 1;
			updateScore ();
			if (count >= numberPickUps) {
				victoryText.text = "You win !";
			}
		}
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		rb.AddForce (new Vector3 (moveHorizontal*groundspeed, 0f, moveVertical*groundspeed), ForceMode.Force);

		if (Input.GetButtonDown("Jump")){
			rb.AddForce (new Vector3 (0f, jumpspeed, 0f), ForceMode.Force);
		}
	}
}
