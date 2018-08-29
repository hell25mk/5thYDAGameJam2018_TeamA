using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHart : MonoBehaviour {

    GameObject player1;
    GameObject player2;

    CLovePower p1;
    CLovePower p2;

    // Use this for initialization
    void Start() {

        player1 = GameObject.Find("PlayerWoman");
        player2 = GameObject.Find("PlayerMan");

        p1 = player1.GetComponent<CLovePower>();
        p2 = player2.GetComponent<CLovePower>();

    }

    // Update is called once per frame
    void Update() {
        


    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if(collision.gameObject.tag == "PlayerWoman") {
            p1.LovePowerUp(20.0f);
        }

        if(collision.gameObject.tag == "PlayerMan") {
            p2.LovePowerUp(20.0f);
        }

    }

}