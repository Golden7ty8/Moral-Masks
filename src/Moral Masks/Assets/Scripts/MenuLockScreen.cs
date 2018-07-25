using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Manages the lock screen.
 * Jobs include:
 * 
 * • Managing the fade in and out of the swipe arrows.
 * • Managing the big timer on the lock screen.
 * 
 * Created by GoldenWay 6/15/2018
 * Modified by GoldenWay 7/15/2018
 * 
 */

public class MenuLockScreen : MonoBehaviour {

	[Header("Options:")]
	[Tooltip("Difference in time for the fade of the different arrows.")]
	public float fadeOutDifferenceTime;
	public float fadeSpeed;

	[Header("References:")]
	public Text[] swipeArrows;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ArrowFadeManager ();
	}

	void ArrowFadeManager () {
		for (int i = 0; i < swipeArrows.Length; i++) {
			swipeArrows [i].color = new Color (255.0f, 255.0f, 255.0f, (Mathf.Cos (Time.time * Mathf.PI * fadeSpeed - Mathf.PI * fadeOutDifferenceTime * i) + 1) * .5f);
		}
	}
}
