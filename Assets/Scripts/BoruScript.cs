using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoruScript : MonoBehaviour
{

    [SerializeField] private int yMin = 0;
    [SerializeField] private int yMax = 5;
    public GameObject boruPrefab;
    private float timer;
    private float timerAdder;
    public float pipeCooldown = 1f;

    private void Start()
    {
        timerAdder = Random.Range(0.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // StartCoroutine("BoruSpawn");

        timer += Time.deltaTime;
        if(timer > pipeCooldown + timerAdder)
        {
            
            var position = new Vector3(transform.position.x, Random.Range(yMin, yMax), 0);
            Instantiate(boruPrefab, position, Quaternion.identity);
            timerAdder = Random.Range(0.5f, 1.5f);

            timer = 0;
        }
    }

    IEnumerator BoruSpawn()
    {
        var position = new Vector3 (transform.position.x, Random.Range (yMin, yMax), 0);
        Instantiate(boruPrefab, position, Quaternion.identity);

        yield return new WaitForSeconds(Random.Range(5, 7));
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
