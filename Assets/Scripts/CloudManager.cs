using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManager : MonoBehaviour
{
    public GameObject[] clouds;
    [SerializeField] private float CloudSpawnRate = 2;
    private float timer = 0f;

    private Vector3[] SpawnPoints = new Vector3[2];

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // Üstteki 2 ile 4 arasý
        SpawnPoints[0] = new Vector3(10f, Random.Range(2f, 4f), 0f);
        // Alttaki -2 -4 arasý
        SpawnPoints[1] = new Vector3(10f,Random.Range(-2f, -4f), 0f);

        timer += Time.deltaTime;

        if(timer > CloudSpawnRate)
        {
            Instantiate(clouds[Random.Range(0, 2)], SpawnPoints[Random.Range(0, 2)], Quaternion.identity);
            timer = 0f;
        }
    }
}
