using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class FinishL2T : MonoBehaviour
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
                   Stats.sceneList.Add("Level2 - Tournament");
             
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
               SceneManager.LoadScene(14);     
            }
                                    
               
            }
    
    
    
    }  
