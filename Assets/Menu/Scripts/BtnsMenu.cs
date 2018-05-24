
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class BtnsMenu : MonoBehaviour {

	public void Update() {
		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}

	public void ChangeScene(string name) {
        SceneManager.LoadScene(name);
	}

	public void ExitGame() {
		Application.Quit();
	}

}