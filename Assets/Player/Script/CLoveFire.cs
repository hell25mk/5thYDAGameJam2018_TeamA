using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLoveFire : MonoBehaviour {

    private float x;
    private float y;
    private float moveSpeed;

	// Use this for initialization
	void Start () {

        moveSpeed = 0.3f;
		
	}
	
	// Update is called once per frame
	void Update () {

        this.x = this.transform.position.x;
        this.y = this.transform.position.y;

        this.transform.position = new Vector2(this.x + moveSpeed, this.y);

    }

}
