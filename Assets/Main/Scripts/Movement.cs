
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class Movement : MonoBehaviour {

	private Vector3 offset;

	public GameObject player;

	public GameObject center;

	public GameObject up;

	public GameObject down;

	public GameObject left;

	public GameObject right;

	public int step = 9;

	public float speed = 0.01f;

	private bool input = true;

	public AudioSource soundPlayer;

	private void Start() {
		AudioSource[] soudeSource = GetComponents<AudioSource> ();
		
		soundPlayer = soudeSource[0];
	}	

	private void Update () {
		if (input == true) {
			if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.W)) { // W
				StartCoroutine ("moveUp"); // StartCoroutine ("moveUp");

				input = false;

				soundPlayer.Play();
			} // Up

			if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) { // W
				StartCoroutine ("moveDown"); // StartCoroutine ("moveDown");

				input = false;

				soundPlayer.Play();
			} // Down

			if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) {
				StartCoroutine ("moveLeft");

				input = false;

				soundPlayer.Play();
			} // Left

			if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) {
				StartCoroutine ("moveRight");

				input = false;

				soundPlayer.Play();
			} // Right
		} // Input
	}

	IEnumerator moveUp () {
		for (int c = 0; c < (90 / step); c++) {
			player.transform.RotateAround (up.transform.position, Vector3.right, step);

			yield return new WaitForSeconds (speed);
		}

		center.transform.position = player.transform.position;

		input = true;
	} // End IEnumerator Up

	IEnumerator moveDown () {
		for (int c = 0; c < (90 / step); c++) {
			player.transform.RotateAround (down.transform.position, Vector3.left, step);

			yield return new WaitForSeconds (speed);
		}

		center.transform.position = player.transform.position;

		input = true;
	} // End IEnumerator Down

	IEnumerator moveLeft () {
		for (int c = 0; c < (90 / step); c++) {
			player.transform.RotateAround (left.transform.position, Vector3.forward, step);

			yield return new WaitForSeconds (speed);
		}

		center.transform.position = player.transform.position;

		input = true;
	} // End IEnumerator Left

	IEnumerator moveRight () {
		for (int c = 0; c < (90 / step); c++) {
			player.transform.RotateAround (right.transform.position, Vector3.back, step);

			yield return new WaitForSeconds (speed);
		}

		center.transform.position = player.transform.position;

		input = true;
	} // End IEnumerator Right

}