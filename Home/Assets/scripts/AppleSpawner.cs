using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour {
	[SerializeField]
	private GameObject[] Apple;
	private BoxCollider2D collider;
	float lim1, lim2;
	// Use this for initialization
	//void Start () {
	//	StartCoroutine (SpawnApple(1f));	
	//}

	void Awake(){
		collider = GetComponent<BoxCollider2D> ();
		lim1 = transform.position.x - collider.bounds.size.x / 2f;
		lim2 = transform.position.x + collider.bounds.size.x / 2f;
	}


	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnApple(float time) {
	
		yield return new WaitForSeconds (time);
		Vector3 pos = transform.position;
		pos.x = Random.Range (lim1, lim2);
		Instantiate (Apple [Random.Range (0, Apple.Length)], pos, Quaternion.identity);
		StartCoroutine (SpawnApple (Random.Range (1f, 2f)));
	
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "Space Man! Total2_0")
			StartCoroutine (SpawnApple (1f));
	}
}
