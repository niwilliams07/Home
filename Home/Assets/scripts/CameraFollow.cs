using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	public Vector3 cameraOffset;

	public bool bounds;
	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;


	void Start () {
		
		cameraOffset = transform.position - player.transform.position;
	}

	void LateUpdate () {
		transform.position = player.transform.position + cameraOffset;

		if (bounds) {

			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
				Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.z),
				Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));
		}
	}



}
