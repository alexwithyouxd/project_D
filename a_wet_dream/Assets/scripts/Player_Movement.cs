using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    
    public float speed;
    public float jumpforce;
    public float move;

    
    [SerializeField] private bool isgrounded;
    
    public Transform groundcheck;
    public float groundcheckradius;
    public LayerMask whatisground;


    public Rigidbody2D rb;

   
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    
    
    
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);


       
        //groundcheck
        isgrounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, whatisground);

        if (Input.GetKeyDown(KeyCode.Space) && isgrounded)
        {
            rb.velocity = Vector2.up * jumpforce;
        }

        

        //flip
        flip();

        

    }






    //functions
    void flip()
    {
        if (move > 0)
        {
            transform.localScale = new Vector3(1.43f, 1.43f, 1f);
        }
        else if (move < 0)
        {
            transform.localScale = new Vector3(-1.43f, 1.43f, 1f);
        }
    }
}
