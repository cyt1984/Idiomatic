
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class CamMovement : MonoBehaviour {

	public Transform target;

	public int cameraSpeed = 15;

	public bool smoothFollow = true;

	void Update () {
		if (target) {
			Vector3 newPs = transform.position;

			newPs.x = target.transform.position.x;

			newPs.z = target.transform.position.z;

			if(!smoothFollow)
				transform.position = newPs;
			else
				transform.position = Vector3.Lerp(transform.position, newPs, cameraSpeed * Time.deltaTime);
		}
	}

	/* public GameObject player;

	private Vector3 offset;

	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	} */
}