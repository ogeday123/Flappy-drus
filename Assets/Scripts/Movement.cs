using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpVelocity;
    private Rigidbody2D rb;
    private Animator animator;
    public AudioSource UiySesiÇıkartıcı;
    public AudioClip Uiy;
    Idrus bird;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        UiySesiÇıkartıcı.clip = null;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            
                rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
                //animator.Play("IdrusJump");
                UiySesiÇıkartıcı.clip = Uiy;
                UiySesiÇıkartıcı.Play();
            

                
        }
        
        

            

        

    }
}
