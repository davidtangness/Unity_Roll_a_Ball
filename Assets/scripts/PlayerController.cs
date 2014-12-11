using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	void FixedUpdate(){
		float movementHorizontal = Input.GetAxis("Horizontal");
		float movementvertical = Input.GetAxis("Vertical");


		Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementvertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
}
