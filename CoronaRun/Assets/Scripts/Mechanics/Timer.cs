using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{

    
    private float startTime;
    private float bestTime;


    public void InitializeTime()
    {
        startTime = Time.time;
    }


    public string DisplayMinutesAndSeconds()
    {
          float time = Time.time - startTime;
            bestTime = (time % 60) / 100;

            string minutes = ((int)time / 60).ToString();
            string seconds = (time % 60).ToString("f2");

            return minutes + ":" + seconds;  

    }

    public void Highscore()
    {
        Debug.Log(bestTime*10);
        Debug.Log(PlayerPrefs.GetFloat("highestTime"));

        if (bestTime*10 < PlayerPrefs.GetFloat("highestTime"))
        {
            PlayerPrefs.SetFloat("highestTime", bestTime*10);
            PlayerPrefs.Save();
        }
    }

    public float GetStartTime()
    {
        return startTime;
    }


    public float GetBestTime()
    {
        return bestTime;
    }

    


}
