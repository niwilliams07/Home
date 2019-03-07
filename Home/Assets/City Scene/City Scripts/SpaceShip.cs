using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpaceShip : MonoBehaviour {

    public Dialogue dialogue;
    public int index;
    public Animator animator;
    private bool help = false;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (animator.GetBool("IsOpen"))
        {
            help = true;
        }
        else { help = false; }
        if ((Input.GetKeyDown("space")) && (help))
        {
            FindObjectOfType<DialogueManager1>().DisplayNextSentence();
        }

        if ((other.gameObject.name == "Space Man! Total2_0") && (!help) && (Input.GetKeyDown("space")) && (GameObject.FindGameObjectsWithTag("fueled").Length > 0))
        {
            FindObjectOfType<DialogueManager1>().StartDialogue(dialogue);
        }

        if ((other.gameObject.name == "Space Man! Total2_0") && (Input.GetKeyDown("space"))  && (GameObject.FindGameObjectsWithTag("fueled").Length < 1))
        {
            SceneManager.LoadScene(index);
        }


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Space Man! Total2_0")
        {
            FindObjectOfType<DialogueManager1>().EndDialogue();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.name == "Space Man! Total2_0") && (!help) && (GameObject.FindGameObjectsWithTag("fueled").Length > 0))
        {
            FindObjectOfType<DialogueManager1>().StartDialogue(dialogue);
        }
    }



}
