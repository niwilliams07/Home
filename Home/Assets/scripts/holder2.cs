using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holder2 : MonoBehaviour
{

    public string dialogue;
    private Dial dMan;

    public string[] dialogueLines;

    // Use this for initialization
    void Start()
    {
        dMan = FindObjectOfType<Dial>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Space Man! Total2_0")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //dMan.ShowBox(dialogue);
                if (!dMan.dialogueActive)
                {
                    dMan.dialogueLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();

                }

            }
        }
    }





}