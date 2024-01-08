using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIMeter : MonoBehaviour
{    public Velocity velocity;
     public RawImage MeterImage;
    void Start()
    {
            velocity  = GameObject.FindObjectOfType<Velocity>();
    }


    void FixedUpdate()
    {
            RectTransform rectTransform = MeterImage.rectTransform;

      
            float rotationAngle = rectTransform.rotation.eulerAngles.z ;
    rectTransform.rotation = Quaternion.Euler(0f, 0f, 90f - velocity.speed * 2);
    }
}
