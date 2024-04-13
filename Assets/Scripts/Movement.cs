using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
      private Rigidbody carRigidbody;
    public Velocity velocity;
    [SerializeField] WheelCollider FrontLeftWheel;
    [SerializeField] WheelCollider FrontRightWheel;
    [SerializeField] WheelCollider BackLeftWheel;   
    [SerializeField] WheelCollider BackRightWheel;

    private float speed = 1500f;
    private int increaseSpeedBonus = 1;
    private float currentSpeed = 0f;
    private float currentSlowingDown = 0f;
   
    private float way;

    private float turning = 20f;
    private float currentTurning = 0f;
      void Start(){ 
             carRigidbody = GetComponent<Rigidbody>();
              velocity  = GameObject.FindObjectOfType<Velocity>();
      }
   private void FixedUpdate()
   { 
      
     HandBrake();
     Vector3 carForwardDirection = transform.forward;

  
        float moving = Vector3.Dot(carForwardDirection, carRigidbody.velocity);

      
   


     way = Input.GetAxis("Vertical"); //<---- směr pohybu

   if(way == -1 ) { 
  if(velocity.speed < 25){             //<---- omezení maximální rychlosti dozadu
     currentSpeed = speed * 1;
       currentSlowingDown = 0f;
   Vector3 forwardForce = transform.forward * way* increaseSpeedBonus; //<------ zrychlení

        carRigidbody.AddForce(forwardForce);
       }
       else
       { 
        
           currentSpeed = 0f;
         currentSlowingDown = 25000f;
       }

    }
        if(way == 1 ) { 
       if(velocity.speed < 91)  {             //<---- omezení maximální rychlosti dopředu
             currentSpeed = speed * -1;
               Vector3 forwardForce = transform.forward * way * increaseSpeedBonus; //<------ zrychlení

        carRigidbody.AddForce(forwardForce);
       currentSlowingDown = 0f;}
         else
       { 
           currentSpeed = 0f;
         currentSlowingDown = 25000f;
       }
    }
       if(way == 0) {                       //<----- zastavení auta když hrač nestikl nic
     currentSlowingDown = 25000f;
    }

       FrontLeftWheel.motorTorque = currentSpeed;   //<------ aplikování rychlosti do všech 4 fyzických kol
       FrontRightWheel.motorTorque = currentSpeed;  
       BackLeftWheel.motorTorque = currentSpeed;
       BackRightWheel.motorTorque = currentSpeed;

        FrontLeftWheel.brakeTorque = currentSlowingDown;        //<----- aplikování síly brzd do kol
         FrontRightWheel.brakeTorque = currentSlowingDown;
       BackLeftWheel.brakeTorque = currentSlowingDown;
       BackRightWheel.brakeTorque = currentSlowingDown;

       currentTurning = turning * Input.GetAxis("Horizontal"); // <----- síla zatáčení
       
       FrontLeftWheel.steerAngle= currentTurning;             // <------ aplikování zatáčení
       FrontRightWheel.steerAngle = currentTurning;

   }
     private void HandBrake()                 //<-------- metoda pro aplikování ruční brzdy
     {
          if(Input.GetKey(KeyCode.Space))            
          { 
                  currentSlowingDown = 100000f;
                  turning = 50f;
                carRigidbody.drag = 0.5f;                 //<------- zesílení zpomalení
                carRigidbody.angularDrag = 0.5f; 

          }
         else
          { 
            carRigidbody.drag = 0.15f; 
                carRigidbody.angularDrag = 0.15f; 
                  turning = 20f;
          }

      }
  
}
