using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class FinishL2 : MonoBehaviour
{
      public Velocity velocity;
  public CheckpointList CheckpointList;
    public Timer timer;
    void Start()
    {
     timer = GameObject.FindObjectOfType<Timer>();
           velocity = GameObject.FindObjectOfType<Velocity>();
            CheckpointList = GameObject.FindObjectOfType<CheckpointList>();
    }

  
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
          if (col.gameObject.name == "Auto")          //<------ jestli se cíle dotkl hráč
            { Scenes.FinishedL2 = true; 
               if(timer.seconds < 61 && timer.minutes < 1 )             //<----- nastavení podmínek podle času pro medaili
                 {                            //
                   Scenes.L2earnedGold = true;                          //
                 }                                                      //
             else     if(timer.seconds < 16 && timer.minutes < 2 )      //
                 {                          //
                   Scenes.L2earnedSilver = true;                        //
                  }                                                     //
                                                                        //
                   else if(timer.seconds < 61 && timer.minutes < 2 )    //
                 {                         //
                   Scenes.L2earnedBronze = true;                        //
                 } 
                 
                   if(Scenes.FinishedL2 == true)
                  {
                    
                             if( timer.minutes < Scenes.minutesL2)
                    {
                          Scenes.minutesL2 = timer.minutes;
                        Scenes.secondsL2 = timer.seconds;
                    
                    }
                            if( timer.minutes == Scenes.minutesL2)
                    {
                          Scenes.minutesL2 = timer.minutes;
                         if( timer.seconds < Scenes.secondsL2) {
                        Scenes.secondsL2 = timer.seconds;
                       }
                    }
                  
                  }
                     Stats.sceneList.Add(SceneManager.GetActiveScene().name);
             
               Stats.dateList.Add(DateTime.Now);
               Stats.speedList.Add(velocity.maxSpeed);
                  Stats.teleportList.Add(CheckpointList.timesTeleported);
                  Stats.timeMinutesList.Add(timer.minutes);
                      Stats.timeSecondsList.Add(timer.seconds);
               SceneManager.LoadScene(0);                              //<---- ukončení závodu
               
            }
    
    
    
    }  
}
