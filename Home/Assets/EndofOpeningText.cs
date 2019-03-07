using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndofOpeningText : MonoBehaviour
{

    public int index;
    private void Awake()
    {
        StartCoroutine(Fading());
    }
        




    IEnumerator Fading()
    {
        yield return new WaitForSecondsRealtime(30);
        SceneManager.LoadScene(index);
    }
}
