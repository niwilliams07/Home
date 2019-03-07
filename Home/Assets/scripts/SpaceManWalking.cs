using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManWalking : MonoBehaviour
{

    public float avatarSpeed;
    private Rigidbody2D rigidbody;
    private Animator animator;

       

    public Vector3 mainPos;
    public int corridor;

    // Use this for initialization
    void Start()
    {
        avatarSpeed = 2;
        animator = this.GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void FixedUpdate()
    {
        float xV = 0f;
        float yV = 0f;
        float zV = 0f;
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetInteger("Face",2);
            yV = avatarSpeed;
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetInteger("Face", 3);
            yV = -avatarSpeed;
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("Face", 4);
            xV = -avatarSpeed;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("Face", 1);
            xV = avatarSpeed;
        }
        if (Input.GetKey("space"))
        {
            //animator.SetTrigger("Stop");
            xV = 0f; yV = 0f;
        }
        rigidbody.velocity = new Vector3(xV, yV, zV);
    }
}

