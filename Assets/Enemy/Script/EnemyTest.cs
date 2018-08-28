using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour {

	private float x;
	private float y;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		x = this.transform.position.x;
		y = this.transform.position.y;

		this.transform.position = new Vector2(x - 0.01f, y);

	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy (gameObject);
		}
	}
}
