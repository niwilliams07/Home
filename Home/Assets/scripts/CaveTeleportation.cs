using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveTeleportation : MonoBehaviour {

	public float x;
	public float y;
	public float z;

	void OnTriggerStay2D(Collider2D other)
	{

		if ((other.gameObject.name == "Space Man! Total2_0") && (Input.GetKeyDown("space")))
			other.transform.position = new Vector3(x, y, z);

	}

}
