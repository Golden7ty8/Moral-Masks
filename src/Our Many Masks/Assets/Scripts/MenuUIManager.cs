using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Contains public functions for buttons to use.
 * Also Acts as a general menu manager.
 * 
 * Created: 7/10/2018 by GoldenWay
 * Modified 7/23/2018 by GoldenWay
 *
 */

public class MenuUIManager : MonoBehaviour {

	[Header("References:")]
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
