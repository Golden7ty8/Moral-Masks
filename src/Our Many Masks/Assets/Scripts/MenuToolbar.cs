using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Manages the toolbar functionality.
 * 
 * Created by GoldenWay on 7/21/2018
 * Modified by GoldenWay on 7/21/2018
 * 
 */

public class MenuToolbar : MonoBehaviour {

	[Header("Options:")] [Range(0.0f, 1.0f)] [Tooltip("How visible is the toolbar what closed? (1 being compleatly hidden and 0 being covering the whole screen).")]
	public float closedPercentage;
	public float slideSpeed;

	[Header("References:")]
	public GameObject panel;

	bool open = false;
	float currentPercentage;

	// Use this for initialization
	void Start () {
		currentPercentage = closedPercentage;
		CloseToolbar ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateDisplay ();
	}

	void UpdateDisplay () {
		RectTransform tmp = panel.GetComponent<RectTransform> ();
		if (open) {
			//If toolbar is meant to be fully open but is not yet in position, continue sliding it upward by decreasing currentPercentage.
			if (tmp.anchoredPosition.y < 0) {
				currentPercentage -= Time.deltaTime * slideSpeed;
			} else {
				currentPercentage = 0;
			}
		} else {
			//If meant to be closed but not yet in position, slide into position by increasing currentPercentage.
			if (tmp.anchoredPosition.y > -QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.height * closedPercentage) {
				currentPercentage += Time.deltaTime * slideSpeed;
			} else {
				currentPercentage = closedPercentage;
			}
		}
		//Update toolbar position using currentPercentage.
		panel.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.0f, -QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.height * currentPercentage);
	}

	public void CloseToolbar () {
		open = false;
	}

	public void OpenToolbar () {
		open = true;
	}

	public void ToggleOpenToolbar () {
		open = !open;
	}

	public void ToolbarSetActive (bool active) {
		panel.SetActive (active);
	}
}
