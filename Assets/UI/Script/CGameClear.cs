﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CGameClear : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider collision) {

        if(collision.gameObject.tag == "PlayerWoman") {
            SceneManager.LoadScene("GameClear");
        }

    }

}
