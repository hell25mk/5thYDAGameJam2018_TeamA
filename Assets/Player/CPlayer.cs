using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer : MonoBehaviour {

    public CLovePower lovePower;
    Rigidbody rigidBody;
    private float x;
    private float y;
    private float moveSpeed;
    private bool jumpFlag;

	// Use this for initialization
	void Start () {

        lovePower = GetComponent<CLovePower>();
        this.rigidBody = GetComponent<Rigidbody>();

        this.x = 0.0f;
        this.y = 1.0f;
        this.moveSpeed = 0.05f;
        this.jumpFlag = false;

	}
	
	// Update is called once per frame
	void Update () {

        AutoMove();

        if(Input.GetKeyDown("space") && !this.jumpFlag) {
            this.rigidBody.AddForce(Vector2.up * 250);
            this.jumpFlag = true;
        }

	}

    public void AutoMove() {

        this.x = this.transform.position.x;
        this.y = this.transform.position.y;

        this.transform.position = new Vector2(this.x + moveSpeed, this.y);

    }

    public void LoveFire() {

        /*if(lovePower.lovePower <= 0) {
            return;
        }*/

        if(Input.GetKeyDown(KeyCode.LeftArrow)) {

        }

    }

    public void OnCollisionEnter(Collision collision) {
        
        if(collision.gameObject.tag == "Ground") {
            this.jumpFlag = false;
        }

    }

}
