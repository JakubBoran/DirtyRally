using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class Scenes : MonoBehaviour
{
  public static bool L1earnedBronze;
  public static bool L1earnedSilver;
  public static bool L1earnedGold;

  public static bool FinishedL1;

  private RawImage L1GoldMedal;
    private RawImage L1SilverMedal;
     private RawImage L1BronzeMedal;
  private void LoadL1Medals() { 
    if(FinishedL1 == true)
    {
  
  
         L1GoldMedal = GameObject.Find("GoldMedalL1").GetComponent<RawImage>();
          L1SilverMedal = GameObject.Find("SilverMedalL1").GetComponent<RawImage>();
          L1BronzeMedal = GameObject.Find("BronzeMedalL1").GetComponent<RawImage>();
             
               L1GoldMedal.canvasRenderer.SetAlpha(0f);
      L1SilverMedal.canvasRenderer.SetAlpha(0f);
     L1BronzeMedal.canvasRenderer.SetAlpha(0f);

     if(L1earnedGold == true)
    {
    L1GoldMedal.canvasRenderer.SetAlpha(1f);
    } 
       else if(L1earnedSilver == true)
    {
    L1SilverMedal.canvasRenderer.SetAlpha(1f);
    } 
      else if(L1earnedBronze == true)
    {
    L1BronzeMedal.canvasRenderer.SetAlpha(1f);
    } 
      } 
      }

  private void Start()
  {
  if(SceneManager.GetActiveScene().name.StartsWith("Menu"))
         {
             L1GoldMedal = GameObject.Find("GoldMedalL1").GetComponent<RawImage>();
          L1SilverMedal = GameObject.Find("SilverMedalL1").GetComponent<RawImage>();
          L1BronzeMedal = GameObject.Find("BronzeMedalL1").GetComponent<RawImage>();
             
               L1GoldMedal.canvasRenderer.SetAlpha(0f);
      L1SilverMedal.canvasRenderer.SetAlpha(0f);
     L1BronzeMedal.canvasRenderer.SetAlpha(0f);
          
           LoadL1Medals();
         }

  }

  public void Tutorial()  {
   SceneManager.LoadScene(1);
   }   
     public void Menu()  {
   SceneManager.LoadScene(0);
   }   
     public void Level1()  {
   SceneManager.LoadScene(2);
   }   
   private void Update() {
            if (Input.GetKeyDown(KeyCode.Escape))
        {         SceneManager.LoadScene(0);
             
        }

  } 
}
