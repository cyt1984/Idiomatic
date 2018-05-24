
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerScript : MonoBehaviour {
	
	public GameObject enemyEmptyPlayer;
	
	private GameObject center, up, right, down, left;

	private void Start () {
		up = enemyEmptyPlayer.transform.Find ("Up").gameObject;

		right = enemyEmptyPlayer.transform.Find ("Right").gameObject;

		down = enemyEmptyPlayer.transform.Find ("Down").gameObject;

		left = enemyEmptyPlayer.transform.Find ("Left").gameObject;
	}

	private void Update () {
		ResetPlayerPosition ();
	}

	public void ResetPlayerPosition () {
		if (this.transform.position.y < -2f || this.transform.position.y > 5f || this.transform.position.x < -15 || this.transform.position.x > 15f || this.transform.position.z < -14 || this.transform.position.z > 14f) {
			this.transform.position = new Vector3 (0f, 1f, 0f);

			this.transform.Rotate (0f, 0f, 0f, Space.World);

			// Position

			/* up.transform.position = new Vector3 (0f, -2f, 2f);

			right.gameObject.transform.position = new Vector3 (2f, -2f, 0f);

			down.gameObject.transform.position = new Vector3 (0f, -2f, -2f);

			left.gameObject.transform.position = new Vector3 (-2f, -2f, 0f); */

			// Rotate

			enemyEmptyPlayer.transform.Rotate (0f, 0f, 0f, Space.World); // Center
			
			up.transform.Rotate (0f, 0f, 0f, Space.World);

			right.gameObject.transform.Rotate (0f, 0f, 0f, Space.World);

			down.gameObject.transform.Rotate (0f, 0f, 0f, Space.World);

			left.gameObject.transform.Rotate (0f, 0f, 0f, Space.World);
		}
	}
	
}