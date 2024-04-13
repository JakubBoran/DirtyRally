using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Stats : MonoBehaviour
{
    
     
    public static List<DateTime> dateList = new List<DateTime>();  
        public static List<string> sceneList = new List<string>();  
         public static List<int> speedList = new List<int>();  
           public static List<int> timeMinutesList = new List<int>();  
             public static List<int> timeSecondsList = new List<int>();
               public static List<int> teleportList = new List<int>();    
    private TextMeshProUGUI Text;
    void Start()
    { 
        Text = GameObject.Find("TextLevel").GetComponent<TextMeshProUGUI>();
       if(speedList.Count > 0) {   
         for (int i = speedList.Count; i > 0; i--)          
        {
            Text.text += "\n" + dateList[i - 1].ToString() + " - " + sceneList[i - 1].ToString()  + " - Max Speed: " + speedList[i - 1].ToString() +" km/h - " + timeMinutesList[i - 1].ToString() + ":" +timeSecondsList[i - 1].ToString() + " - Teleported: " + teleportList[i - 1].ToString() + " times";


        } }
      
    }
   
  
 
}
