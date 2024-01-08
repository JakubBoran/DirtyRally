using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Tutorial : MonoBehaviour
{    
    public TextMeshProUGUI TutorialText;
    public Button OkButton;
    private List<string> textList = new List<string>();
    private  int tutorialPart = 0;
    
    void Start()
    {  textList.Add("Press ESC to enter menu");

        TutorialText.text = textList[tutorialPart];
           textList.Add("Press W or S to move forward and backward");
          textList.Add("Press A or D while moving to move to side");
            textList.Add("Press SPACE to activate the handbrake");
                 textList.Add("When you pass a checkpoint, press R to return to the last one");
    }

  
    void Update()
    {
        
    }
         public void TutorialNextText()  {
           if(tutorialPart < textList.Count - 1) 
           {
                tutorialPart++;
           TutorialText.text = textList[tutorialPart];
           }  
           else
            {
                 TutorialText.enabled = false;
           OkButton.gameObject.SetActive(false);
            }
          
   }  
}
