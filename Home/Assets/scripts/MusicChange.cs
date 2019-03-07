using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChange : MonoBehaviour {
	public Animator anim;
	public Animator newMusic;
	public Animator talk;
	public AudioSource music;


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Space Man! Total2_0") {
			anim.SetBool ("inCave", true);
			newMusic.SetBool ("playing", true);
			talk.SetBool ("talking", true);
			StartCoroutine (stopTalking ());
		}
	}

	IEnumerator stopTalking(){
		yield return new WaitForSeconds (6f);
		talk.SetBool ("talking", false);

	}
}
