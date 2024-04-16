using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class FinishedL2MP : MonoBehaviour
{    public Velocity velocity;
  public CheckpointList CheckpointList;
    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.FindObjectOfType<Timer>();
           velocity = GameObject.FindObjectOfType<Velocity>();
            CheckpointList = GameObject.FindObjectOfType<CheckpointList>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void OnTriggerEnter(Collider col)
    {
          if (col.gameObject.name == "Auto")          //<------ jestli se cíle dotkl hráč
            {          
             
                 Scenes.minutesL2P1 = timer.minutes;         //<----- čas hráče 1 se zapíše
                  Scenes.secondsL2P1 = timer.seconds;  
                     Stats.sceneList.Add("Level2 - P1");
             
               Stats.dateList.Add(DateTime.Now);
               Stats.speedList.Add(velocity.maxSpeed);
                  Stats.teleportList.Add(CheckpointList.timesTeleported);
                  Stats.timeMinutesList.Add(timer.minutes);
                      Stats.timeSecondsList.Add(timer.seconds); 
                     SceneManager.LoadScene(9);  
            }
                                   
               
            }
    
    
    
    }  
