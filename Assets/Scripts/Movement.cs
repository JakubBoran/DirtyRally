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

      
   


     way = Input.GetAxis("Vertical");

   if(way == -1 ) { 
  if(velocity.speed < 25){ 
     currentSpeed = speed * 1;
       currentSlowingDown = 0f;
       }
       else
       { 
           currentSpeed = 0f;
         currentSlowingDown = 25000f;
       }


            if (moving < 0)
        { 
             currentSpeed = speed * 1;
       currentSlowingDown = 50000f;
         //car goes backwards
        }

    }
        if(way == 1 ) { 
        if (moving > 0)
        {   
            currentSpeed = speed * -1;
       currentSlowingDown = 50000f;
        }
        else    if(velocity.speed < 91)  {
             currentSpeed = speed * -1;
       currentSlowingDown = 0f;}
         else
       { 
           currentSpeed = 0f;
         currentSlowingDown = 25000f;
       }
    }
       if(way == 0) { 
     currentSlowingDown = 25000f;
    }

       FrontLeftWheel.motorTorque = currentSpeed;
       FrontRightWheel.motorTorque = currentSpeed;
       BackLeftWheel.motorTorque = currentSpeed;
       BackRightWheel.motorTorque = currentSpeed;

        FrontLeftWheel.brakeTorque = currentSlowingDown;
         FrontRightWheel.brakeTorque = currentSlowingDown;
       BackLeftWheel.brakeTorque = currentSlowingDown;
       BackRightWheel.brakeTorque = currentSlowingDown;

       currentTurning = turning * Input.GetAxis("Horizontal");
       
       FrontLeftWheel.steerAngle= currentTurning;
       FrontRightWheel.steerAngle = currentTurning;

   }
     private void HandBrake() 
     {
          if(Input.GetKey(KeyCode.Space))
          { 
                  currentSlowingDown = 100000f;
                  turning = 50f;
                carRigidbody.drag = 0.5f; 
                carRigidbody.angularDrag = 0.5f; 

          }
         else
          { 
            carRigidbody.drag = 0f; 
                carRigidbody.angularDrag = 0.05f; 
                  turning = 20f;
          }

      }
  
}
