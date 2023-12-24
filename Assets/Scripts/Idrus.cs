using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Idrus : MonoBehaviour
{
    [SerializeField] public int point = 0;
    public GameObject pointText;
    public GameObject gameOverScene;
    public AudioClip Dido, breakShield, huh;
    public bool gameOver = false;
    public bool shield;
    Rigidbody2D rb;
    public float shieldJumpVelocity;
    public Sprite normalBird, shieldBird;
    public float shieldTimer = 0, shieldTimer2 = 0;


    // Start is called before the first frame update
    void Start()
    {
        gameOverScene.SetActive(false);
        this.GetComponent<AudioSource>().enabled = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        pointText.GetComponent<TextMeshProUGUI>().text = "Point: " + point;

        if(shield == true)
        {
            shieldTime();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (shield == true)
        {

            rb.freezeRotation = true;


            if (collision.gameObject.CompareTag("Boru") && !gameOver)
            {
                rb.freezeRotation = false;
                rb.velocity = new Vector2(rb.velocity.x, shieldJumpVelocity);
                shield = false;
                GetComponent<SpriteRenderer>().sprite = normalBird;
                GetComponent<AudioSource>().PlayOneShot(breakShield);
                shieldTimer = 0;
            }
        }
        else
        {
            
            if (collision.gameObject.CompareTag("Boru") && !gameOver)
            {
                
                this.GetComponent<Movement>().enabled = false;
                gameOverScene.SetActive(true);
                this.GetComponent<AudioSource>().clip = Dido;
                this.GetComponent<AudioSource>().Play();
                gameOver = true;
                

            }
        }

        


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Shield"))
        {
            shield = true;
            GetComponent<SpriteRenderer>().sprite = shieldBird;
        }


    }

    
     void shieldTime()
    {
        shieldTimer += Time.deltaTime;

        if (shieldTimer > 10)
        {
            shieldTimer2 += Time.deltaTime;
            if (shieldTimer2 >= 0 && shieldTimer2 < 0.5f)
            {
                GetComponent<SpriteRenderer>().sprite = normalBird;
            }
            else if (shieldTimer2 >= 0.5f && shieldTimer2 < 1)
            {
                GetComponent<SpriteRenderer>().sprite = shieldBird;
            }
            else if (shieldTimer2 >= 1 && shieldTimer2 < 1.5f)
            {
                GetComponent<SpriteRenderer>().sprite = normalBird;
            }
            else if (shieldTimer2 >= 1.5f && shieldTimer2 < 2f)
            {
                GetComponent<SpriteRenderer>().sprite = shieldBird;
            }
            else if (shieldTimer2 >= 2 && shieldTimer2 < 2.25f)
            {
                GetComponent<SpriteRenderer>().sprite = normalBird;
            }
            else if (shieldTimer2 >= 2.5f && shieldTimer2 < 2.75)
            {
                GetComponent<SpriteRenderer>().sprite = shieldBird;
            }
            else if (shieldTimer2 >= 2.75 && shieldTimer2 < 3f)
            {
                GetComponent<SpriteRenderer>().sprite = normalBird;
            }
            else if (shieldTimer2 >= 3f && shieldTimer2 < 3.25f)
            {
                GetComponent<SpriteRenderer>().sprite = shieldBird;
            }
            else if (shieldTimer2 >= 3.25)
            {
                shieldTimer = 0;
                shieldTimer2 = 0;
                GetComponent<SpriteRenderer>().sprite = normalBird;
                GetComponent<AudioSource>().PlayOneShot(huh);
                shield = false;
            }


        }
    }
    


}
