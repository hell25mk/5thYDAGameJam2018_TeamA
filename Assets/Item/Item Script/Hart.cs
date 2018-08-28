using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hart : MonoBehaviour {

    //取得された
    bool isGotten;

    [SerializeField]
	int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    /*
        public bool IsGotten(){
            return isGotten;
        }

        public int GetScore(){
            return score;
        }
    */
}
