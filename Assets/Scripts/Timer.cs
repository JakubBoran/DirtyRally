using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Timer : MonoBehaviour
{    private TextMeshProUGUI timerText;
    
    public float timer;
    public int seconds;
    public int minutes;
    void Start()
    {
       timerText = GameObject.Find("CurrentTimeText").GetComponent<TextMeshProUGUI>();
       
    }

 
    void Update()
    {
        timer += Time.deltaTime;
          if (timer > 1f)
        {
            seconds++;
            timer = 0;
        }
   
        if (seconds > 59)
        {
            seconds = 0;
            minutes++;
        }
      timerText.text = minutes +":" + seconds;
    }
}
