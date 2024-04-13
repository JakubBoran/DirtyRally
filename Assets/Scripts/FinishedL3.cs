using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class FinishedL3 : MonoBehaviour
{   public Velocity velocity;
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
            { Scenes.FinishedL3 = true; 
               if(timer.seconds < 31 && timer.minutes < 2 )             //<----- nastavení podmínek podle času pro medaili
                 {                           //
                   Scenes.L3earnedGold = true;                          //
                 }                                                      //
             else     if(timer.seconds < 61 && timer.minutes < 2 )      //
                 {                          //
                   Scenes.L3earnedSilver = true;                        //
                  }                                                     //
                                                                        //
                   else if(timer.seconds < 31 && timer.minutes < 3 )    //
                 {                          //
                   Scenes.L3earnedBronze = true;                        //
                 }
                   if(Scenes.FinishedL3 == true)
                  {
                    
                            if( timer.minutes < Scenes.minutesL3)
                    {
                          Scenes.minutesL3 = timer.minutes;
                        Scenes.secondsL3 = timer.seconds;
                    
                    }
                            if( timer.minutes == Scenes.minutesL3)
                    {
                          Scenes.minutesL3 = timer.minutes;
                         if( timer.seconds < Scenes.secondsL3) {
                        Scenes.secondsL3 = timer.seconds;
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

