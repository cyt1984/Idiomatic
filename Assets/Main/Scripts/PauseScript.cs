
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

// using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			if(Time.timeScale == 1)
				Time.timeScale = 0;
			else 
				Time.timeScale = 1;
		}

		/* if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("Menu"); */
	}

}