using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GoinsideHouse : MonoBehaviour {

    public int index;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Space Man! Total2_0")
            SceneManager.LoadScene(index);
    

    
		
	}
}
