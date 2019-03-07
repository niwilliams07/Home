using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasPumps : MonoBehaviour {

    public Dialogue dialogue;
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

        if ((other.gameObject.name == "Space Man! Total2_0") && (Input.GetKeyDown("space")) && (!help) && (GameObject.FindGameObjectsWithTag("Carmelizer").Length > 0))
        {
            FindObjectOfType<DialogueManager1>().StartDialogue(dialogue);
        }

        if ((other.gameObject.name == "Space Man! Total2_0") && (Input.GetKeyDown("space")) && (!help) && (GameObject.FindGameObjectsWithTag("Carmelizer").Length < 1))
        {
            Destroy(this.gameObject);
        }


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Space Man! Total2_0")
        {
            FindObjectOfType<DialogueManager1>().EndDialogue();
        }
    }



}
