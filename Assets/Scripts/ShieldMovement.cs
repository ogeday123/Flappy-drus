using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShieldMovement : MonoBehaviour
{
    public float shieldSpeed;
    
    private void Update()
    {
        transform.Translate(Vector3.left * shieldSpeed * Time.deltaTime);

        if (transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Idrus"))
        {
            Destroy(gameObject);
        }
    }
}
