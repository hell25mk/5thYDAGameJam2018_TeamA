using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour {

	private float x;
	private float y;
	private int []EnemyMovePatern;
	private int MovePaternNum;

	// Use this for initialization
	void Start () {
		
		EnemyMovePatern = new int[] { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2 };
		MovePaternNum = 0;



	}

	// Update is called once per frame
	void Update () {

		x = this.transform.position.x;
		y = this.transform.position.y;

		//this.transform.position = new Vector2(x - 0.01f, y);

		switch (EnemyMovePatern[MovePaternNum]) {
		case 1: 
			this.transform.position = new Vector2 (x - 0.01f, y);
			MovePaternNum++;
			break;

		case 2:
			this.transform.position = new Vector2 (x + 0.01f, y);
			MovePaternNum++;
			break;
		}
		if (MovePaternNum > EnemyMovePatern.Length-2) {
			MovePaternNum = 0;
		}

		Debug.Log (MovePaternNum);

	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy (gameObject);
		}
	}
}
