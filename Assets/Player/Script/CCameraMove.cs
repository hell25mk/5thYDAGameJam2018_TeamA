using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCameraMove : MonoBehaviour {

    [SerializeField] private GameObject player;

	// Use this for initialization
	void Start () {

        this.transform.position = new Vector3(player.transform.position.x, 0.0f, -10.0f);

	}
	
	// Update is called once per frame
	void Update () {

        this.transform.position = new Vector3(this.transform.position.x + 0.05f, 0.0f, -10.0f);

	}

}
