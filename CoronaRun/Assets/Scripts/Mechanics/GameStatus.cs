using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    public Text bestTimeText;

    Timer timer;

    public bool hs=false;
    public static bool goalReached=false;


    public int level = 1;

    void Start()
    {

        timer = FindObjectOfType<Timer>();

        timer.InitializeTime();
 
        if (PlayerPrefs.GetFloat("highestTime") == 0.00f)
        {
            PlayerPrefs.SetFloat("highestTime", 10f);
        }

        if (hs)
        {
            bestTimeText.text = PlayerPrefs.GetFloat("highestTime").ToString("f4");

        }
        
        
    }

    void Update()
    {
        timerText.text = timer.DisplayMinutesAndSeconds();
 

        if (goalReached)
        {
            GoalReached();
        }
        
    }

    public void GoalReached()
    {
        level++;
        if (hs)
        {
            timer.Highscore();
            bestTimeText.text = PlayerPrefs.GetFloat("highestTime").ToString("f4");
        }
  
    }


}
