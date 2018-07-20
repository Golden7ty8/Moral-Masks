using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Provides easy links to objects and scripts in other scripts
 * by simply typeing QuickLinks.quickLinks.* where * is any public
 * non-static value listed below.
 * 
 * Created by GoldenWay on 7/20/2018
 * Modified by GoldenWay on 7/20/2018
 * 
 */

public class QuickLinks : MonoBehaviour {

	public static QuickLinks quickLinks;

	[Header("References:")]
	public UIManager uIManager;

	void Awake () {
		quickLinks = this;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
