﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveAttackMusic : MonoBehaviour 
{

	public AudioSource audioClip;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Space Man! Total2_0")
		{
			audioClip.Play ();
		}
	}
}