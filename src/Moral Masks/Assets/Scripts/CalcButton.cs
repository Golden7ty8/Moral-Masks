using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Manages the calculator buttons.
 * 
 * Created by GoldenWay on 7/12/2018
 * Modified by GoldenWay on 7/21/2018
 * 
 */

public class CalcButton : MonoBehaviour {

	public Text label;

	public RectTransform rectTransform
	{
		get
		{
			if (_rectTransform == null)
				_rectTransform = GetComponent<RectTransform> ();
			return _rectTransform;
		}
	}
	RectTransform _rectTransform;

	public CalcManager calcManager
	{
		get
		{
			if (_calcManager == null)
				_calcManager = GetComponentInParent<CalcManager> ();
			return _calcManager;
		}
	}
	static CalcManager _calcManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTapped() {
		//Debug.Log ("Tapped: " + label.text);
		calcManager.ButtonTapped (label.text [0]);
	}
}
