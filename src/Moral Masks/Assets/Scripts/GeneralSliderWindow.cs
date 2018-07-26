using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Controls sliding window functionality.
 * 
 * Created by GoldenWay on 7/21/2018
 * Modified by GoldenWay on 7/26/2018
 * 
 */

public class GeneralSliderWindow : MonoBehaviour {

	public enum ScreenEdge {Left, Right, Up, Down};

	[Header("Options:")] [Range(0.0f, 1.0f)] [Tooltip("How visible is the window when closed? (1 being compleatly hidden and 0 being covering the whole screen).")]
	public float closedPercentage;
	public float openPercentage;
	public float slideSpeed;
	//[Tooltip("False for vertical sliding, true for horizontal sliding.")]
	//public bool horizontal;
	public ScreenEdge edge;

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
		float canvasHeight = QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.height;
		float canvasWidth = QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.width;
		float directionModifier;
		switch (edge) {
		case ScreenEdge.Left:
			break;
		case ScreenEdge.Right:
			break;
		case ScreenEdge.Up:
			break;
		case ScreenEdge.Down:
			directionModifier = -canvasHeight;
			break;
		default:
			Debug.LogWarning ("SliderWindow Direction cannot be determined.");
			break;
		}
		if (open) {
			//print ("open");
			//If toolbar is meant to be fully open but is not yet in position, continue sliding it upward by decreasing currentPercentage.
			if (-canvasHeight * (currentPercentage - Time.deltaTime * slideSpeed) < openPercentage) {
				currentPercentage -= Time.deltaTime * slideSpeed;
			} else {
				currentPercentage = openPercentage;
			}
		} else {
			//If meant to be closed but not yet in position, slide into position by increasing currentPercentage.
			if (-canvasHeight * (currentPercentage + Time.deltaTime * slideSpeed) > -canvasHeight * closedPercentage + 0.1f) {
				currentPercentage += Time.deltaTime * slideSpeed;
			} else {
				currentPercentage = closedPercentage;
			}
			//print (tmp.anchoredPosition.y + ", " + -QuickLinks.quickLinks.mainCanvas.GetComponent<RectTransform> ().rect.height * closedPercentage);
		}
		//Update toolbar position using currentPercentage.
		panel.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0.0f, -canvasHeight * currentPercentage);
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
