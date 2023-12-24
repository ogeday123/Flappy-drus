using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamaManager : MonoBehaviour
{
    public Idrus bird;
    bool paused = false;

    void Start()
    {
        
    }


    void Update()
    {
        if(bird.gameOver == false)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                paused = true;
            }

            if(paused == true)
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    Time.timeScale = 1;
                }
            }
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
