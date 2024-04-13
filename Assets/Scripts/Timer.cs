using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{    private TextMeshProUGUI timerText;
    
 private TextMeshProUGUI BestTimeL1;
  private TextMeshProUGUI BestTimeL2;
   private TextMeshProUGUI BestTimeL3;
 
    public float timer;
    public int seconds;
    public int minutes;

    public static int tournamentSeconds = 0;
    public static int tournamentMinutes = 0;
    void Start()
    {  
       timerText = GameObject.Find("CurrentTimeText").GetComponent<TextMeshProUGUI>();
       
       if(Scenes.FinishedL1 == true && SceneManager.GetActiveScene().name == "Level1"){
              BestTimeL1= GameObject.Find("NewBestTimeTextL1").GetComponent<TextMeshProUGUI>();
         BestTimeL1.text = "Best Time " +  Scenes.minutesL1 + ":" + Scenes.secondsL1;
       }
       if(Scenes.FinishedL2 == true && SceneManager.GetActiveScene().name == "Level2"){
              BestTimeL2= GameObject.Find("NewBestTimeTextL2").GetComponent<TextMeshProUGUI>();
         BestTimeL2.text = "Best Time " +  Scenes.minutesL2 + ":" + Scenes.secondsL2;
       }
        if(Scenes.FinishedL3 == true && SceneManager.GetActiveScene().name == "Level3"){
              BestTimeL3= GameObject.Find("NewBestTimeTextL3").GetComponent<TextMeshProUGUI>();
         BestTimeL3.text = "Best Time " +  Scenes.minutesL3 + ":" + Scenes.secondsL3;
       }
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
