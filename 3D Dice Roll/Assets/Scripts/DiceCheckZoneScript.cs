using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour {

	Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity = DiceScript.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		//Dice 1 Check
		if (col.transform.parent.tag == "Dice1")
		{
			if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
			{
				switch (col.gameObject.name)
				{
					case "Side 1":
						DiceNumberTextScript.dice1Number = 6;
						break;
					case "Side 2":
						DiceNumberTextScript.dice1Number = 5;
						break;
					case "Side 3":
						DiceNumberTextScript.dice1Number = 4;
						break;
					case "Side 4":
						DiceNumberTextScript.dice1Number = 3;
						break;
					case "Side 5":
						DiceNumberTextScript.dice1Number = 2;
						break;
					case "Side 6":
						DiceNumberTextScript.dice1Number = 1;
						break;
				}
			}
		}
		//Dice 2 Check
		if (col.transform.parent.tag == "Dice2")
		{
			if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
			{
				switch (col.gameObject.name)
				{
					case "Side 1":
						DiceNumberTextScript.dice2Number = 6;
						break;
					case "Side 2":
						DiceNumberTextScript.dice2Number = 5;
						break;
					case "Side 3":
						DiceNumberTextScript.dice2Number = 4;
						break;
					case "Side 4":
						DiceNumberTextScript.dice2Number = 3;
						break;
					case "Side 5":
						DiceNumberTextScript.dice2Number = 2;
						break;
					case "Side 6":
						DiceNumberTextScript.dice2Number = 1;
						break;
				}
			}
		}
	}
}
