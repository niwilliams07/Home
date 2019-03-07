using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AppleCatch : MonoBehaviour {
	public Text scoreText;
	public int score;
	public int index;

	void Awake(){
		scoreText = GameObject.Find ("Score").GetComponent<Text> ();
		scoreText.text = "0";
	
	}

	void OnTriggerEnter2D(Collider2D target){
		
		if (target.tag == "Apple") {
			target.gameObject.SetActive (false);
			score++;
			scoreText.text = score.ToString ();
		
		} else if (target.tag == "Bad Apple") {
			target.gameObject.SetActive (false);
			score -= 10;
			scoreText.text = score.ToString ();
		}

		if (scoreText.text == "20") {
			SceneManager.LoadScene(index);
		}
	
	}
		
}
