using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRFW : MonoBehaviour
{    private float forwardOrBackwards;
  private float leftOrRight;
    private Animator animator;
    private float rotationTime;
   

    void Start()
    {
           
    }


    void Update()
    { leftOrRight = Input.GetAxis("Horizontal");
      forwardOrBackwards = Input.GetAxis("Vertical");
       

Transform carTransform = transform.parent;

Quaternion carRotation = carTransform.rotation;
   Vector3 carEulerAngles = carRotation.eulerAngles;
if (leftOrRight == 1)
{

    carEulerAngles.y += 45;
    carRotation = Quaternion.Euler(carEulerAngles);
    transform.rotation = carRotation;
}
        if(leftOrRight == -1)
        {
 
    carEulerAngles.y -= 45;
    carRotation = Quaternion.Euler(carEulerAngles);
    transform.rotation = carRotation;
        }
        if(leftOrRight == 0)
        {
 
    carEulerAngles.y += 0;
    carRotation = Quaternion.Euler(carEulerAngles);
    transform.rotation = carRotation;
        }
        if(forwardOrBackwards == 1 || forwardOrBackwards == -1 ){  
             CarMoving();
        }
        
           if(forwardOrBackwards == 0 ){  
           rotationTime = 0;
             Vector3 newRotationFront = transform.eulerAngles;
            newRotationFront.x = -90;
            transform.eulerAngles = newRotationFront;
        }
        

    }
    private void CarMoving()  
    { 

          rotationTime += Time.deltaTime;
           Vector3 newRotationFront = transform.eulerAngles;

    if (rotationTime >= 0.2f && rotationTime < 0.4f)
    {
               newRotationFront.x = -180;
            transform.eulerAngles = newRotationFront;
    }
    else if (rotationTime >= 0.4f && rotationTime < 0.6f)
    {
                newRotationFront.x = -270;
            transform.eulerAngles = newRotationFront;
    }
    else if (rotationTime >= 0.6f && rotationTime < 0.8f)
    {
             newRotationFront.x = -360;
            transform.eulerAngles = newRotationFront;
    }
    else if (rotationTime >= 0.8f)
    {
               newRotationFront.x = -450;
            transform.eulerAngles = newRotationFront;
            rotationTime = 0;
    }


    }
}