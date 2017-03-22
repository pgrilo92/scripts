﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;					// The player's score.
	public Text text;

	//private playerMove playerControl;	// Reference to the player control script.
	private int previousScore = 0;			// The score in the previous frame.


	//void Awake ()
	//{
		// Setting up the reference.
		//playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMove>();
	//}


	void FixedUpdate ()
	{
		// Set the score text.
		text.text = "Score: " + score;

		// If the score has changed...
		if(previousScore != score)
			// ... play a taunt.

		// Set the previous score to this frame's score.
		previousScore = score;
	}

}
