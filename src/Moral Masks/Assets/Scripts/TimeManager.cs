using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Manages the day and time.
 * 
 * Created by GoldenWay on 7/17/2018
 * Modified by GoldenWay on 7/17/2018
 * 
 */

public class TimeManager : MonoBehaviour {

	[Header("References:")]
	public Text timeText;
	public Text dayText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BigTimerManager ();
	}

	void BigTimerManager () {
		if (timeText == null)
			print ("null");
		if ((int)Time.time % 2 == 0) {
			timeText.text = "12:00 am";
		} else {
			timeText.text = "12 00 am";
		}
	}
}
