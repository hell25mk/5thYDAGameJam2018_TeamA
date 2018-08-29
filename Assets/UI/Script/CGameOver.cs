using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CGameOver : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if(collision.gameObject.tag == "PlayerWoman") {
            SceneManager.LoadScene("GameOver");
        }

        if(collision.gameObject.tag == "PlayerMan") {
            SceneManager.LoadScene("GameOver");
        }

    }

}
