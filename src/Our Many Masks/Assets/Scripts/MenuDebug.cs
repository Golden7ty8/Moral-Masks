using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * This script manages the display of the debug menu.
 * 
 * Created by GoldenWay on 7/22/2018
 * Modified by GoldenWay on 7/22/2018
 * 
 */

public class MenuDebug : MonoBehaviour {

	[Header("Options:")]
	public float fPSRefeshRate;

	[Header("References:")]
	public Text fPSText;

	int fPSCounter = 0;
	float timeCounter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdateDisplay ();
	}

	void UpdateDisplay () {
		FPSDisplay ();
	}

	void FPSDisplay () {
		//fPSText.text = ((int)(1.0f / Time.deltaTime)).ToString ();
		fPSCounter++;
		timeCounter += Time.deltaTime;
		if (timeCounter >= fPSRefeshRate) {
			fPSText.text = "FPS: " + ((float)fPSCounter / fPSRefeshRate);
			fPSCounter = 0;
			timeCounter -= fPSRefeshRate;
		}
	}
}
