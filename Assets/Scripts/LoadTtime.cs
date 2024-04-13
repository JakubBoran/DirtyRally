using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class LoadTtime : MonoBehaviour
{   private TextMeshProUGUI Ttime;
    public static bool golden;
       public static bool silver;
          public static bool bronze;
               private TextMeshProUGUI placeText;
    // Start is called before the first frame update
    void Start()
    {
        Ttime = GameObject.Find("TextTime").GetComponent<TextMeshProUGUI>();
        Ttime.text = Timer.tournamentMinutes.ToString() + ":" + Timer.tournamentSeconds;
            placeText = GameObject.Find("placeText").GetComponent<TextMeshProUGUI>();
            if(golden == true)   
            {
                     placeText.text = "You earned the gold medal";   
             }
               else if(silver == true)   
            {
                   placeText.text = "You earned the silver medal";    
             }
               else if(bronze== true)   
            {
                  placeText.text = "You earned the bronze medal";    
             }
     else    
            {
                  placeText.text = "";    
             }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
             public void Menu()  {
         SceneManager.LoadScene(0);
   } 
}
