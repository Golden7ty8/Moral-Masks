﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Contains public functions for buttons to use.
 * 
 * Created: 7/10/2018 by GoldenWay
 * Modified 7/11/2018 by GoldenWay
 *
 */

public class UIManager : MonoBehaviour {

	public GameObject currentMenu;

	// Use this for initialization
	void Start () {
		ActivateMenu (currentMenu);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ActivateMenu (GameObject menu) {
		currentMenu.SetActive (false);
		menu.SetActive (true);
		currentMenu = menu;
	}

	/*public void AddScene (string sceneName) {
		SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
	}*/
}
