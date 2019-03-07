using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDestroyer : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Apple" || other.tag == "Bad Apple") 
		{
			other.gameObject.SetActive (false);
		}
	}

	void Update () {
		
	}
}
