using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAppleGrove : MonoBehaviour {

	public GameObject player;
	public Vector3 cameraOffset;
	public BoxCollider2D collider1;

	public bool bounds2;
	public Vector3 minCameraPos2;
	public Vector3 maxCameraPos2;

	void Update (){
	}


	void OnTriggerEnter2D(Collider collider1){
		cameraOffset = transform.position - player.transform.position;
		transform.position = player.transform.position + cameraOffset;

		if (collider1.gameObject.name == "Space Man! Total2_0") {

			if (bounds2) {

				transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos2.x, maxCameraPos2.x),
					Mathf.Clamp(transform.position.y, minCameraPos2.y, maxCameraPos2.z),
					Mathf.Clamp(transform.position.z, minCameraPos2.z, maxCameraPos2.z));


			}

		}

	}


}
