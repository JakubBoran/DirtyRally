using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using TMPro;
public class FinishL3T : MonoBehaviour
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
          if (col.gameObject.name == "Auto")          
            { 
                   Stats.sceneList.Add("Level3 - Tournament");
             
               Stats.dateList.Add(DateTime.Now);
               Stats.speedList.Add(velocity.maxSpeed);
                  Stats.teleportList.Add(CheckpointList.timesTeleported);
                  Stats.timeMinutesList.Add(timer.minutes);
                      Stats.timeSecondsList.Add(timer.seconds);
                Timer.tournamentMinutes += timer.minutes;
                Timer.tournamentSeconds += timer.seconds;
                if(Timer.tournamentSeconds > 59)  {
                   Timer.tournamentMinutes++;
                   Timer.tournamentSeconds -= 60;

                }
                Scenes.FinishedT = true;
              
               if(Timer.tournamentSeconds < 41 && Timer.tournamentMinutes < 3 )             //<----- nastavení podmínek podle času pro medaili
                 {                             //
                   Scenes.TearnedGold = true;     
                   LoadTtime.golden = true;
                     LoadTtime.silver = false;
                       LoadTtime.bronze = false;

                     
                 }                                                      //
             else     if(Timer.tournamentSeconds < 61 && Timer.tournamentMinutes < 4 )      //
                 {                            //
                   Scenes.TearnedSilver = true;   
                     LoadTtime.golden = false;
                     LoadTtime.silver = true;
                       LoadTtime.bronze = false;
                               
                  }                                                     //
                                                                        //
                   else if(Timer.tournamentSeconds < 61 && Timer.tournamentMinutes< 5 )    //
                 {                            //
                   Scenes.TearnedBronze = true;       
                     LoadTtime.golden = false;
                     LoadTtime.silver = false;
                       LoadTtime.bronze = true;
                           
                 }
                 else   {  LoadTtime.golden = false;
                     LoadTtime.silver = false;
                       LoadTtime.bronze = false;  }
                  
                 
                  SceneManager.LoadScene(15);    
                    
            }
                                    
               
            }
    
    
    
    }  
