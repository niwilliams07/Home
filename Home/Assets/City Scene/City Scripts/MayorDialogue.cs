using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayorDialogue : MonoBehaviour
{
    public Dialogue dialogue;
    public Dialogue quest1;
    public Dialogue done;
    public Dialogue eating;
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

        if ((other.gameObject.tag == "Player") && (Input.GetKeyDown("space")) && (!help) && (GameObject.FindGameObjectsWithTag("Carmelizer").Length > 0))
        {
            FindObjectOfType<DialogueManager1>().StartDialogue(dialogue);
            StartCoroutine(helper(other));
        }



        if ((other.gameObject.tag == "quest1") && (Input.GetKeyDown("space")) && (!help))
        {
            FindObjectOfType<DialogueManager1>().StartDialogue(quest1);

        }

        if ((other.gameObject.tag == "quest1") && (Input.GetKeyDown("space")) && (!help) && (GameObject.FindGameObjectsWithTag("Carmelizer").Length < 1))
        {
            FindObjectOfType<DialogueManager1>().StartDialogue(done);
            StartCoroutine(player(other));
        }

        if ((other.gameObject.tag == "Player") && (Input.GetKeyDown("space")) && (!help) && (GameObject.FindGameObjectsWithTag("Carmelizer").Length < 1))
        {
            FindObjectOfType<DialogueManager1>().StartDialogue(eating);
        }

        }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Space Man! Total2_0")
        {
            FindObjectOfType<DialogueManager1>().EndDialogue();
        }
    }

    IEnumerator helper(Collider2D other)
    {
        yield return new WaitForSeconds(.5f);
        other.gameObject.tag = "quest1";
    }

    IEnumerator player(Collider2D other)
    {
        yield return new WaitForSeconds(.5f);
        other.gameObject.tag = "Player";
    }

}