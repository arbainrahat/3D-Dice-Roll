using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour {

	static Rigidbody rb;
	public static Vector3 diceVelocity;
	public Vector3 offSet;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		diceVelocity = rb.velocity;

		if (Input.GetKeyDown (KeyCode.Space)) {
			DiceRoll();
		}
	}
	public void DiceRoll()
    {
		DiceNumberTextScript.diceNumber = 0;
		DiceNumberTextScript.dice1Number = 0;
		DiceNumberTextScript.dice2Number = 0;
		float dirX = Random.Range(0, 10000);
		float dirY = Random.Range(0, 10000);
		float dirZ = Random.Range(0, 10000);
		transform.position = new Vector3(0, 10f, 0) + offSet;
		transform.rotation = Quaternion.identity;
		rb.AddForce(transform.up * 10);
		rb.AddTorque(dirX, dirY, dirZ);
	}
}
