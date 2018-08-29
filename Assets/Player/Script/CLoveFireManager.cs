using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLoveFireManager : MonoBehaviour {

    [SerializeField] private GameObject loveFirePrf;
    [SerializeField] private CLovePower lovePower;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {
		


	}

    public void FireCreate(Transform transform) {

        if(lovePower.LovePowerDown(10.0f)){
            Instantiate(this.loveFirePrf, transform.position, Quaternion.identity);
        }

    }

}
