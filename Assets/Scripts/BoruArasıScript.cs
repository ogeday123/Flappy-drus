using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruArasıScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Idrus"))
        {
            collision.GetComponent<Idrus>().point++;
        }
    }
}
