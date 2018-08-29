using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CPlayer : MonoBehaviour {
    
    private CLoveFireManager loveFireManager;
    [SerializeField] private KeyCode keyAttack;
    [SerializeField] private KeyCode keyJump;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpSpeed;

    private Rigidbody rigidBody;
    private float x;
    private float y;
    
    private bool jumpFlag;

	// Use this for initialization
	void Start () {

        loveFireManager = GameObject.Find("LoveFireManager").GetComponent<CLoveFireManager>();
        this.rigidBody = GetComponent<Rigidbody>();

        this.x = 0.0f;
        this.y = 1.0f;
        this.jumpFlag = false;

	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space)) {
            SceneManager.LoadScene("Title");
        }

        AutoMove();

        if(Input.GetKeyDown(keyJump) && !this.jumpFlag) {
            this.rigidBody.AddForce(Vector2.up * jumpSpeed);
            this.jumpFlag = true;
        }

        if(Input.GetKeyDown(keyAttack)) {
            loveFireManager.FireCreate(this.transform);
        }

	}

    public void AutoMove() {

        this.x = this.transform.position.x;
        this.y = this.transform.position.y;

        this.transform.position = new Vector2(this.x + moveSpeed, this.y);

    }

    public void OnCollisionEnter(Collision collision) {
        
        if(collision.gameObject.tag == "Ground") {
            this.jumpFlag = false;
        }

    }

}
