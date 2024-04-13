using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class FinishedL2MP2 : MonoBehaviour
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
                  Scenes.FinalminutesL2P1 = Scenes.minutesL2P1;
                  Scenes.FinalsecondsL2P1 = Scenes.secondsL2P1;  
                 Scenes.minutesL2P2 = timer.minutes;
                  Scenes.secondsL2P2 = timer.seconds;   
                  Scenes.FinishedL2MP = true;
                     Stats.sceneList.Add("Level2 - P2");
             
               Stats.dateList.Add(DateTime.Now);
               Stats.speedList.Add(velocity.maxSpeed);
                  Stats.teleportList.Add(CheckpointList.timesTeleported);
                  Stats.timeMinutesList.Add(timer.minutes);
                      Stats.timeSecondsList.Add(timer.seconds);
                     SceneManager.LoadScene(0);  
            }
                               
               
            }
    
    
    
    }  