
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class Tutorial : MonoBehaviour {

	public Image sinopse;

	public Text btnText;

	public Sprite en, pt;

	private AudioSource uiConfirmation;

	public bool playTrack = false;

	public void LateUpdate() {
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("Menu");
	}

	public void Start() {
		uiConfirmation = GetComponent<AudioSource> ();
	}

	public void ChangeScene(string name) {
        SceneManager.LoadScene(name);
	}

	public void ChangeImg() {
		if(btnText.text.ToString() == "Português") {
			btnText.text = "English";

			sinopse.sprite = pt;
		} else {
			btnText.text = "Português";

			sinopse.sprite = en;
		}

		if(playTrack)
			uiConfirmation.Play();
	}

}