using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CLovePower : MonoBehaviour {

    [SerializeField] private Text lpPoint;
    public float lovePower {
        get {
            return lovePower;
        }
        set {
            lovePower = value;
        }
    }
    private float timer;

	// Use this for initialization
	void Start () {

        this.lpPoint.text = GetComponent<Text>().text;
        this.lovePower = 100.0f;
	}
	
	// Update is called once per frame
	void Update () {

        this.lpPoint.text = "LP" + this.lovePower.ToString("f1") + "%";

        timer -= Time.deltaTime;
        if(timer <= 0.0f) {
            timer = 1.0f;
            this.lovePower -= 0.1f;
        }

	}

}
