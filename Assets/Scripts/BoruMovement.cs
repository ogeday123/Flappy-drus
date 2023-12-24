using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruMovement : MonoBehaviour
{
    public float moveSpeed;
    public Idrus bird;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime); 

        if(transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }


}
