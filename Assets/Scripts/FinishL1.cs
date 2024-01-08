using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishL1 : MonoBehaviour
{
    public Timer timer;
    void Start()
    {
        timer = GameObject.FindObjectOfType<Timer>();
    }

  
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
          if (col.gameObject.name == "Auto")
            { 
               if(timer.seconds < 31 && timer.minutes < 1 )  
                 {Scenes.FinishedL1 = true;
                   Scenes.L1earnedGold = true;
                 }
             else     if(timer.seconds < 46 && timer.minutes < 1 )  
                 {Scenes.FinishedL1 = true;
                   Scenes.L1earnedSilver = true;
                 }
          
                   else if(timer.seconds < 61 && timer.minutes < 1 )  
                 { Scenes.FinishedL1 = true;
                   Scenes.L1earnedBronze = true;
                 }
                 
               SceneManager.LoadScene(0);
               
            }
    
    
    
    }  
}