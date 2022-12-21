using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class time_controller : MonoBehaviour
{  
    public float timeRemaining = 0;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;
    private void Start()
    {
        // Starts the timer automatically
       
    
    }
    void Update()
    {
         if(strat_button.start)
            {
                float minutes = Mathf.FloorToInt(timeRemaining / 60); 
                float seconds = Mathf.FloorToInt(timeRemaining % 60);
                timeText.text = string.Format("Time:"+"{0:00}:{1:00}", minutes, seconds);
                strat_button.start=false;
                 timerIsRunning = true;
            }
        if (timerIsRunning)
        {
            /*
            if (timeRemaining > 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
               // timeRemaining = 0;
                timerIsRunning = false;
            }*/
           
          
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("Time:"+"{0:00}:{1:00}", minutes, seconds);
    }

}
