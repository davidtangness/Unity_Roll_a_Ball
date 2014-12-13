using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public UnityEngine.UI.Text CounterText;
	public UnityEngine.UI.Text WinText;
	private int count;

	void start()
	{
		count = 0;
	}

	void Update()
	{
		CounterText.text = "Score: " + count.ToString ();
		if (count >= 7) 
		{
			WinText.text = "YOU WIN!";
		}
	}

	void FixedUpdate(){
		float movementHorizontal = Input.GetAxis("Horizontal");
		float movementVertical = Input.GetAxis("Vertical");


		Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			count = count + 1;

		}
	}
}
