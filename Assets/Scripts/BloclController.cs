using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloclController : MonoBehaviour {

	private SpriteRenderer sr;
	int colorMarker = 1;
	int frameCount;
	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		sr.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		frameCount += 1;
		if (frameCount % 5 == 0) {
			if (colorMarker == 1) {
				sr.color = Color.magenta;
				colorMarker = 2;
			} else if (colorMarker == 2) {
				sr.color = Color.gray;
				colorMarker = 1;
			}
		}
	}
}
