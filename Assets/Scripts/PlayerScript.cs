using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
	

	public float speed;
	private Rigidbody2D rb;
	private SpriteRenderer sr;
	private int PWstate;
	private int collectCounter;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
		sr.color = Color.red;
		PWstate = 1;

	}

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			sr.color = Color.white;
			PWstate = 2;
		}
		else
		{
			sr.color = Color.red;
			PWstate = 1;
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
			rb.AddForce (movement * speed);


		}
		print (PWstate);
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "TheWinSpot"&&collectCounter>=10){
			SceneManager.LoadScene ("Winner");

		}
		if (other.gameObject.tag == "Particle"&&PWstate==1) {
			print ("Collision");
			DestroyObject (other.gameObject);
			collectCounter += 1;
		}

		if (other.gameObject.tag == "Wave"&&PWstate==2) {
			print ("Collision");
			DestroyObject (other.gameObject);
			collectCounter += 1;
		}
	}
}