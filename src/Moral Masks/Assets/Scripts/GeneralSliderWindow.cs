using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Manages the toolbar functionality.
 * 
 * Created by GoldenWay on 7/21/2018
 * Modified by GoldenWay on 7/24/2018
 * 
 */

public class GeneralSliderWindow : MonoBehaviour {

	[Header("Options:")] [Range(0.0f, 1.0f)] [Tooltip("How visible is the toolbar when closed? (1 being compleatly hidden and 0 being covering the whole screen).")]
	public float closedPercentage;
	public float openPercentage;
	public float slideSpeed;
	[Tooltip("False for vertical sliding, true for horizontal sliding.")]
	public bool horizontal;

	[Header("References:")]
	public GameObject panel;

	bool open = false;
	float currentPercentage;

	// Use this for initialization
	void Start () {
		currentPercentage = closedPercentage;
		CloseWindow ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateDisplay ();
	}

	void UpdateDisplay () {
		//RectTransform tmp = panel.GetComponent<RectTransform> ();
		if (open) {
			//print ("open");
			//If toolbar is meant to be fully open but is not yet in position, continue sliding it upward by decreasing currentPercentage.
			if (-QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.height * (currentPercentage - Time.deltaTime * slideSpeed) < 0) {
				currentPercentage -= Time.deltaTime * slideSpeed;
			} else {
				currentPercentage = 0;
			}
		} else {
			//If meant to be closed but not yet in position, slide into position by increasing currentPercentage.
			if (-QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.height * (currentPercentage + Time.deltaTime * slideSpeed) > -QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.height * closedPercentage + 0.1f) {
				currentPercentage += Time.deltaTime * slideSpeed;
			} else {
				currentPercentage = closedPercentage;
			}
			//print (tmp.anchoredPosition.y + ", " + -QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.height * closedPercentage);
		}
		//Update toolbar position using currentPercentage.
		panel.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.0f, -QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.height * currentPercentage);
	}

	public void CloseWindow () {
		open = false;
	}

	public void OpenWindow () {
		open = true;
	}

	public void ToggleOpenWindow () {
		open = !open;
	}

	public void WindowSetActive (bool active) {
		panel.SetActive (active);
	}
}
