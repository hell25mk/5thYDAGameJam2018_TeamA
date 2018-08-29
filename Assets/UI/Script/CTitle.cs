
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CTitle : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }


    // Update is called once per frame
    void Update() {

        if(Input.GetKey(KeyCode.Space)) {
            SceneManager.LoadScene("Stage1");
        }

        if(Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }

    }


}
