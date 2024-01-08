using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Particles : MonoBehaviour
{    public Velocity velocity;
    private float way;
    public ParticleSystem L1Particle1;
    public ParticleSystem  L1Particle2;
    public ParticleSystem  L1Particle3;
    public ParticleSystem  L1Particle4;
    public ParticleSystem  L1Particle5;
    public ParticleSystem  L1Particle6;

    void Start()
    {
                  velocity  = GameObject.FindObjectOfType<Velocity>();
    }

   
    void Update()
    {    way = Input.GetAxis("Vertical");
    
         if(SceneManager.GetActiveScene().name.StartsWith("Level1"))
         {     if(way == 1 ) 
            {   
             L1Particle1.Play(true);
            L1Particle2.Play(true);
            L1Particle3.Play(true);
            L1Particle4.Play(true);
            L1Particle5.Play(true);
            L1Particle6.Play(true);

            }
             else  if(velocity.speed <= 1) 
            {  
            L1Particle1.Pause(true);
            L1Particle2.Pause(true);
            L1Particle3.Pause(true);
            L1Particle4.Pause(true);
            L1Particle5.Pause(true);
            L1Particle6.Pause(true);

            L1Particle1.Clear(true);
            L1Particle2.Clear(true);
            L1Particle3.Clear(true);
            L1Particle4.Clear(true);
            L1Particle5.Clear(true);
            L1Particle6.Clear(true);
            }
       
       
         }
    }
}
