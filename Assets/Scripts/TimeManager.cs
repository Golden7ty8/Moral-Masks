﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * Manages the day and time.
 * 
 * Created by GoldenWay on 7/17/2018
 * Modified by GoldenWay on 7/17/2018
 * 
 */

public class TimeManager : MonoBehaviour {

	[Header("References:")]
	public TextMeshProUGUI timeText;
	public TextMeshProUGUI dayText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BigTimerManager ();
	}

	void BigTimerManager () {
		if ((int)Time.time % 2 == 0) {
			timeText.text = "12:00 am";
		} else {
			timeText.text = "12 00 am";
		}
	}
}
