using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Velocity : MonoBehaviour
{
    private Rigidbody rb;
      public TextMeshProUGUI speedText;
        public float speed; 
        public int maxSpeed;
    void Start()
    {
      
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
            Vector3 velocity = rb.velocity;

      
             speed = velocity.magnitude * 2f;          
             speedText.text = "" + (int)speed;
            if(speed > maxSpeed)   {
                    maxSpeed = (int)speed;
             }
         
          
    }
}
