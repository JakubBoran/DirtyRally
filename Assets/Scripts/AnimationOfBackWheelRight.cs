using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOfBackWheelRight : MonoBehaviour
{private float forwardOrBackwards;
  
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
  
    {  
         forwardOrBackwards = Input.GetAxis("Vertical");
        if(forwardOrBackwards == 1 ||forwardOrBackwards == -1 )
        {
      animator.SetBool("IsCarMoving", true);
           
        }
         if(forwardOrBackwards == 0)
        {
     
           animator.SetBool("IsCarMoving", false);
        }
       
    }
}
