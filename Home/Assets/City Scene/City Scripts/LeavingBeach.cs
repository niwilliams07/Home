using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LeavingBeach : MonoBehaviour
{

    public int index;
    private void OnTriggerStay2D(Collider2D other)
    {


        if ((other.gameObject.name == "Space Man! Total2_0") && (Input.GetKeyDown("space")) && (GameObject.FindGameObjectsWithTag("fueled").Length < 1))
        {
            SceneManager.LoadScene(index);
        }


    }


}