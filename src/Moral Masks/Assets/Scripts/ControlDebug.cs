using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Manages Debug controls.
 * 
 * Created by GoldenWay on 7/21/2018
 * Modified by GoldenWay on 7/21/2018
 * 
 */

public class ControlDebug : MonoBehaviour {

	public GameObject debugDisplay;

	bool togglePressed = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DebugControlsManager ();
	}

	void DebugControlsManager () {
		if (Debug.isDebugBuild) {
			if (Input.GetAxisRaw ("Debug Toggle") == 1) {
				if (!togglePressed) {
					togglePressed = true;
					debugDisplay.SetActive (!debugDisplay.activeSelf);
				}
			} else {
				togglePressed = false;
			}
		}
	}
}
