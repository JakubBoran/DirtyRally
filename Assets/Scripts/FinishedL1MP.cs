using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class FinishedL1MP : MonoBehaviour
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
          if (col.gameObject.name == "Auto")         
            {          
             
                 Scenes.minutesL1P1 = timer.minutes;
                  Scenes.secondsL1P1 = timer.seconds;   
                     Stats.sceneList.Add("Level1 - P1");
             
               Stats.dateList.Add(DateTime.Now);
               Stats.speedList.Add(velocity.maxSpeed);
                  Stats.teleportList.Add(CheckpointList.timesTeleported);
                  Stats.timeMinutesList.Add(timer.minutes);
                      Stats.timeSecondsList.Add(timer.seconds);
                     SceneManager.LoadScene(8);  
            }
                                   
               
            }
    
    
    
    }  

