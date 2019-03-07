using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Palace2Beach : MonoBehaviour
{
    public int index;
    public float x;
    public float y;
    public float z;
    public Animator cam1;
    public Animator cam2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = new Vector3(x, y, z);
            cam1.SetBool("trans", false);
            cam2.SetBool("tel", false);
        }
        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(index);
        }
    }
}
