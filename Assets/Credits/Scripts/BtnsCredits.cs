
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class BtnsCredits : MonoBehaviour {

	public void Update() {
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("Menu");
	}
	
	public void ChangeScene(string name) {
        SceneManager.LoadScene(name);
	}

	public void AccessSite(string site) {
		Application.OpenURL(site);
	}

}