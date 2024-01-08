using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineAudio : MonoBehaviour
{  private float way;
    public Velocity velocity;
    public AudioSource Engine;
    public AudioClip IdleEngine;
    public AudioClip ForwardEngine;
    public  AudioClip BackwardEngine;

    private bool playingIdle;
    private bool playingForward;
       private bool playingBackward;
    void Start()
    {
          velocity  = GameObject.FindObjectOfType<Velocity>();
   
       
    }

      
    void Update()
    {
        way = Input.GetAxis("Vertical");
            if(velocity.speed <= 1 || way == 0)  
         {   if(playingIdle == false) 
            {
            Engine.clip = IdleEngine; 
                  playingIdle = true;   
                  playingForward = false;  
                  playingBackward = false;  
                  Engine.Stop();
                  Engine.Play();
            }
                 
                 
         }
         else if(way == 1 )  
         {  if(playingForward == false) 
            {
            Engine.clip = ForwardEngine; 
                  playingForward = true;    
                  playingIdle = false;  
                  playingBackward = false;  
                  Engine.Stop();
                  Engine.Play();
            }
             
            
         }
         else if(way == -1 )  
         {  if(playingBackward == false) 
            {
            Engine.clip = BackwardEngine; 
                  playingBackward = true;   
                  playingForward = false;  
                  playingIdle = false;   
                  Engine.Stop();
                  Engine.Play();
            }
                 
              
         }
    }
}
