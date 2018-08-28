using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayerAnimation : MonoBehaviour {
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			animator.SetBool ("Rigth_walk", true);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			animator.SetBool ("Left_walk", true);
		}
	}
}
