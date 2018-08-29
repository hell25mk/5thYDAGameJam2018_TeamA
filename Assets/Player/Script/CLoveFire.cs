using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLoveFire : MonoBehaviour {

    private float x;
    private float ox;
    private float y;
    private float moveSpeed;

	// Use this for initialization
	void Start () {

        this.x = this.transform.position.x;
        this.y = this.transform.position.y;
        this.ox = this.x;
        this.moveSpeed = 0.2f;

    }
	
	// Update is called once per frame
	void Update () {

        if(this.x - this.ox > 6.0f) {
            Destroy(this.gameObject);
        }

        this.x = this.transform.position.x;
        this.y = this.transform.position.y;

        this.transform.position = new Vector2(this.x + moveSpeed, this.y);

    }

}
