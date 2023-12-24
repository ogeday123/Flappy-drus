using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpVelocity;
    private Rigidbody2D rb;
    private Animator animator;
    public AudioSource UiySesi��kart�c�;
    public AudioClip Uiy;
    Idrus bird;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        UiySesi��kart�c�.clip = null;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            
                rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
                //animator.Play("IdrusJump");
                UiySesi��kart�c�.clip = Uiy;
                UiySesi��kart�c�.Play();
            

                
        }
        
        

            

        

    }
}
