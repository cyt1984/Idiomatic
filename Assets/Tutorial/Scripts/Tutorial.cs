
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

	public Image sinopse;

	public Text btnText;

	public Sprite en, pt;

	public void Update() {
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("Menu");
	}

	public void ChangeScene(string name) {
        SceneManager.LoadScene(name);
	}

	public void ChangeImg() {
		if(btnText.text.ToString() == "Pt") {
			btnText.text = "En";

			sinopse.sprite = pt;
		} else {
			btnText.text = "Pt";

			sinopse.sprite = en;
		}
	}

}