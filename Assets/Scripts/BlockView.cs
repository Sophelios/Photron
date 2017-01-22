using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockView : MonoBehaviour {

	// Use this for initialization
	private SpriteRenderer sr;
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		sr.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			sr.enabled = false;
		}
		if (Input.GetKeyUp(KeyCode.Space)){
			sr.enabled = true;
		}
		
	}
}
