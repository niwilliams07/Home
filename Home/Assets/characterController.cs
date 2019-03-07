using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

    public float speed = 10.0f;
    public Animator anim;
	// Use this for initialization
	void Start () {
       
        anim = this.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {

        AudioSource audio = GetComponent<AudioSource>();
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        if (translation > 0) 
        {
            anim.SetInteger("Face", 2);
        }
        else if (translation < 0)
        {
            anim.SetInteger("Face", 3);
        }
        
        if (straffe > 0)
        {
            anim.SetInteger("Face", 1);
        }
        else if (straffe < 0) 
        {
            anim.SetInteger("Face", 4);
        }
        if ((translation == 0) && (straffe == 0))
        {
            anim.SetInteger("Face", 0);
        }
        transform.Translate(straffe, translation, 0);




        

    }


}
