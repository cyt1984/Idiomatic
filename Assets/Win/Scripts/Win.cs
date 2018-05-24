
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
	
	private void Update() {
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("Menu");
	}
	
	public void ChangeScene(string name) {
		SceneManager.LoadScene(name);
	}

}