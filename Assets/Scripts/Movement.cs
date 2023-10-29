using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
      private Rigidbody carRigidbody;

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
             
      }
   private void FixedUpdate()
   {  
     Vector3 carForwardDirection = transform.forward;

  
        float moving = Vector3.Dot(carForwardDirection, carRigidbody.velocity);

      
   


     way = Input.GetAxis("Vertical");
   if(way == -1) { 
     currentSpeed = speed * 1;
       currentSlowingDown = 0f;
            if (moving < 0)
        { 
             currentSpeed = speed * 1;
       currentSlowingDown = 30000f;
         //car goes backwards
        }

    }
        if(way == 1) { 
        if (moving > 0)
        {
            currentSpeed = speed * -1;
       currentSlowingDown = 30000f;
        }
        else   {
             currentSpeed = speed * -1;
       currentSlowingDown = 0f;}
    }
       if(way == 0) { 
     currentSlowingDown = 30000f;
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
  
}
