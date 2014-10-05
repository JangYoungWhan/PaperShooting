using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	// Title screen script

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;

		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect (
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonWidth
			);

		// Draw a button to start the game
		if(GUI.Button(buttonRect, "Start!"))
		{
			// On Click, load the first level.
			// "Stage 1" is the name of the first scene we created.
			Application.LoadLevel("Stage1");
		}
	}
}
