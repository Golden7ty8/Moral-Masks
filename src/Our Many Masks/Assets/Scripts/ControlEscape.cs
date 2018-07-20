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

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Escape pressed?
		if (Input.GetAxisRaw ("Cancel") == 1) {
			//Are we on the main menu or the lock screen?
			if (QuickLinks.quickLinks.uIManager.currentMenu == mainMenu || QuickLinks.quickLinks.uIManager.currentMenu.name == "Lock Screen") {
				Application.Quit ();
			} else {
				QuickLinks.quickLinks.uIManager.ActivateMenu (mainMenu);
			}
		}
	}
}
