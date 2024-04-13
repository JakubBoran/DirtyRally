using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MenuTimer : MonoBehaviour
{ private TextMeshProUGUI timeToStartText;
   public float timer;
   public int timeToStart;
    
        public Scenes scenes;
    void Start()
    {  scenes = GameObject.FindObjectOfType<Scenes>();
         timer = 0;
         timeToStart = 3;
        timeToStartText = GameObject.Find("TimeCounter").GetComponent<TextMeshProUGUI>();
        timeToStartText.text = timeToStart.ToString();
         timeToStartText.color = new Color(255,0,0);
         timeToStartText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(scenes.startLevel == true) {
  timer += Time.deltaTime;
        timeToStartText.enabled = true;
          if(timer > 1) 
          {
              timer = 0;
              timeToStart-- ;
       
           }

        }
           timeToStartText.text = timeToStart.ToString();
                     if(timeToStart == 0) 
              { timeToStartText.enabled = false;
               SceneManager.LoadScene(scenes.sceneNumber);
          
               }
                    if(timeToStart == 3) 
              {
              timeToStartText.color = new Color(255,0,0);
               }
                  if(timeToStart == 2) 
              {
              timeToStartText.color = new Color(255,165,0);
               }
                   if(timeToStart == 1) 
              {
              timeToStartText.color = new Color(0,255,0);
          
               }
          
    }
   
}
