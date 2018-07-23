using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Manages the escape control, which should allow you to
 * exit to a previous menu or if you are on the main menu, will quit.
 * 
 * Created by GoldenWay on 7/20/2018
 * Modified by GoldenWay on 7/20/2018
 * 
 */

public class ControlEscape : MonoBehaviour {

	public GameObject mainMenu;

	//This variable prevents the code from running multiple times from holding down the button.
	private bool escapeHeld = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Escape pressed just now?
		if (Input.GetAxisRaw ("Cancel") == 1 && escapeHeld == false) {
			escapeHeld = true;
			//Are we on the main menu or the lock screen?
			if (QuickLinks.quickLinks.menuUIManager.currentMenu == mainMenu || QuickLinks.quickLinks.menuUIManager.currentMenu.name == "Lock Screen") {
				Application.Quit ();
			} else {
				QuickLinks.quickLinks.menuUIManager.ActivateMenu (mainMenu);
			}
		} else if (Input.GetAxisRaw("Cancel") != 1) {
			escapeHeld = false;
		}
	}
}
