﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	private float x;
	private float y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x = this.transform.position.x;
		y = this.transform.position.y;


		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.position = new Vector2 (x + 0.1f, y);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.position = new Vector2 (x - 0.1f, y);

		}

     	} 
}
