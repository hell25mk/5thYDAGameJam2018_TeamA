using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLoveFireManager : MonoBehaviour {

    public GameObject loveFirePrf;

	// Use this for initialization
	void Start () {

        this.loveFirePrf = (GameObject)Resources.Load("Player/Bullet/LoveFirePrf");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void FireCreate() {

        Debug.Log("ファイアを生成");
        Instantiate(this.loveFirePrf, transform.position, Quaternion.identity);

    }

}
