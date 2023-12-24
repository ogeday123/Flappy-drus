using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(Vector3.left * (moveSpeed + Random.Range(0.5f, 1.5f)) * Time.deltaTime);

        if (transform.position.x < -11)
        {
            Destroy(gameObject);
        }
    }
}
