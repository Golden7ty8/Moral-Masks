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

	float fPSCounter = 0;
	float TimeCounter = 0;

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
		TimeCounter += Time.deltaTime;
		if (TimeCounter >= fPSRefeshRate) {
			fPSText.text = "FPS: " + (fPSCounter / fPSRefeshRate).ToString ();
			fPSCounter = 0;
			TimeCounter -= fPSRefeshRate;
		}
	}
}
