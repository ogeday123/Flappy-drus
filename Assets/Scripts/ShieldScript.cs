using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShieldScript : MonoBehaviour
{
    [SerializeField] private int yMin = 0;
    [SerializeField] private int yMax = 5;
    public GameObject shieldPrefab;
    [SerializeField] private float timer, shieldTimer;
    public int shieldSpawn = 0;
    public Idrus idrus;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(idrus.shield == false)
        {
            timer += Time.deltaTime;
            if (timer > 5 && timer < 10)
            {

                shieldTimer += Time.deltaTime;
                if (shieldTimer >= 1)
                {
                    shieldSpawn = Random.Range(0, 1);
                    shieldTimer = 0;
                }

                if (shieldSpawn == 1)
                {
                    var position = new Vector3(12, Random.Range(yMin, yMax), 0);
                    Instantiate(shieldPrefab, position, Quaternion.identity);
                    

                    timer = 0;
                }
            }
            else if (timer >= 10)
            {
                
                    var position = new Vector3(12, Random.Range(yMin, yMax), 0);
                    Instantiate(shieldPrefab, position, Quaternion.identity);
                    

                    timer = 0;
                
            }

           
        }
    }




}
