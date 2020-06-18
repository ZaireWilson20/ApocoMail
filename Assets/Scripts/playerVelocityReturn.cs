using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerVelocityReturn : MonoBehaviour
{
    Animator animator;
    private float xMove = 0;
    private float yMove = 0;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        xMove = rb.velocity.x;
        yMove = rb.velocity.y;
        //Debug.Log(yMove);
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("walksouth2") != true && 
            animator.GetCurrentAnimatorStateInfo(0).IsName("walknorth2") != true)
        {
            animator.SetFloat("XMovement", xMove);
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("walkside2") != true && 
            animator.GetCurrentAnimatorStateInfo(0).IsName("walkside2 0") != true)
        {
            animator.SetFloat("YMovement", yMove);
        }
        if(  xMove > 0)
        {
            sr.flipX = false;
        }
        else if ( xMove < 0)
        {
            sr.flipX = true;
        }


    }
}
