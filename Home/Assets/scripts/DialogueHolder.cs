using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

    public string dialogue;
    private DialogueManager dMan;
    public string[] dialogueLines;


	void Start () {
        dMan = FindObjectOfType<DialogueManager>();
	}
	

	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Space Man! Total2_0")
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
				//dMan.ShowBox(dialogue);
                if(!dMan.dialogueActive)
                {
                    dMan.dialogueLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();

                }

            }
        }
    }

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.name == "Space Man! Total2_0") {
			dMan.dialogueActive = false;
			dMan.dBox.SetActive(false);
		
		}
	}
        


    }


