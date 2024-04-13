using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class FinishL1 : MonoBehaviour
{     public Velocity velocity;
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
            { Scenes.FinishedL1 = true; 
               if(timer.seconds < 31 && timer.minutes < 1 )             //<----- nastavení podmínek podle času pro medaili
                 {                             //
                   Scenes.L1earnedGold = true;                          //
                 }                                                      //
             else     if(timer.seconds < 46 && timer.minutes < 1 )      //
                 {                            //
                   Scenes.L1earnedSilver = true;                        //
                  }                                                     //
                                                                        //
                   else if(timer.seconds < 61 && timer.minutes < 1 )    //
                 {                            //
                   Scenes.L1earnedBronze = true;                        //
                 } 
                  
                  if(Scenes.FinishedL1 == true)
                  {
                    
                       if( timer.minutes < Scenes.minutesL1)
                    {
                          Scenes.minutesL1 = timer.minutes;
                        Scenes.secondsL1 = timer.seconds;
                    
                    }
                            if( timer.minutes == Scenes.minutesL1)
                    {
                          Scenes.minutesL1 = timer.minutes;
                         if( timer.seconds < Scenes.secondsL1) {
                        Scenes.secondsL1 = timer.seconds;
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