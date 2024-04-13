using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class Scenes : MonoBehaviour
{ public MenuTimer menuTimer;  
  public bool startLevel;
public int sceneNumber;

 public static bool TearnedBronze;
  public static bool TearnedSilver;
  public static bool TearnedGold;

public static bool FinishedT;

private TextMeshProUGUI L3TextP1;
    private TextMeshProUGUI L3TextP2;

public static bool FinishedL3MP;

public static int FinalminutesL3P1;
 public static int FinalsecondsL3P1;

public static int minutesL3P1;
 public static int secondsL3P1;
public static int minutesL3P2;
 public static int secondsL3P2;


   private TextMeshProUGUI L2TextP1;
    private TextMeshProUGUI L2TextP2;

public static bool FinishedL2MP;

public static int FinalminutesL2P1;
 public static int FinalsecondsL2P1;

public static int minutesL2P1;
 public static int secondsL2P1;
public static int minutesL2P2;
 public static int secondsL2P2;




    private TextMeshProUGUI L1TextP1;
    private TextMeshProUGUI L1TextP2;
public static bool FinishedL1MP;


public static int FinalminutesL1P1;
 public static int FinalsecondsL1P1;


public static int minutesL1P1;
 public static int secondsL1P1;
public static int minutesL1P2;
 public static int secondsL1P2;


public static int minutesL1 = 100;
 public static int secondsL1= 100;

public static int minutesL2 = 100;
 public static int secondsL2 = 100;
 
 public static int minutesL3 = 100;
 public static int secondsL3 = 100;

  public static bool L1earnedBronze;
  public static bool L1earnedSilver;
  public static bool L1earnedGold;

  public static bool FinishedL1;
  
  public static bool L2earnedBronze;
  public static bool L2earnedSilver;
  public static bool L2earnedGold;

   public static bool FinishedL2;

    
  public static bool L3earnedBronze;
  public static bool L3earnedSilver;
  public static bool L3earnedGold;

   public static bool FinishedL3;

  private RawImage L1GoldMedal;
    private RawImage L1SilverMedal;
     private RawImage L1BronzeMedal;

     
  private RawImage L2GoldMedal;
    private RawImage L2SilverMedal;
     private RawImage L2BronzeMedal;
     
       private RawImage L3GoldMedal;
    private RawImage L3SilverMedal;
     private RawImage L3BronzeMedal;
   private RawImage TGoldMedal;
    private RawImage TSilverMedal;
     private RawImage TBronzeMedal;
 private void LoadL3MP()
  {
    if(FinishedL3MP == true)
    {
           L3TextP1 = GameObject.Find("TextMwin3P1").GetComponent<TextMeshProUGUI>();
           L3TextP2 = GameObject.Find("TextMwin3P2").GetComponent<TextMeshProUGUI>();

           L3TextP1.text = FinalminutesL3P1 + ":" + FinalsecondsL3P1;
           L3TextP2.text = minutesL3P2 + ":" + secondsL3P2;
    }
  }

 private void LoadL2MP()
  {
    if(FinishedL2MP == true)
    {
           L2TextP1 = GameObject.Find("TextMwin2P1").GetComponent<TextMeshProUGUI>();
           L2TextP2 = GameObject.Find("TextMwin2P2").GetComponent<TextMeshProUGUI>();

           L2TextP1.text = FinalminutesL2P1 + ":" + FinalsecondsL2P1;
           L2TextP2.text = minutesL2P2 + ":" + secondsL2P2;
    }
  }

  private void LoadL1MP()
  {
    if(FinishedL1MP == true)
    {
           L1TextP1 = GameObject.Find("TextMwin1P1").GetComponent<TextMeshProUGUI>();
           L1TextP2 = GameObject.Find("TextMwin1P2").GetComponent<TextMeshProUGUI>();

           L1TextP1.text = FinalminutesL1P1 + ":" + FinalsecondsL1P1;
           L1TextP2.text = minutesL1P2 + ":" + secondsL1P2;
    }
  }
  
  private void LoadL1Medals() { 
    if(FinishedL1 == true) //<---- jestli hráč dokončil Level 1
    {
  
  
         L1GoldMedal = GameObject.Find("GoldMedalL1").GetComponent<RawImage>();
          L1SilverMedal = GameObject.Find("SilverMedalL1").GetComponent<RawImage>();
          L1BronzeMedal = GameObject.Find("BronzeMedalL1").GetComponent<RawImage>();
             
               L1GoldMedal.canvasRenderer.SetAlpha(0f);
      L1SilverMedal.canvasRenderer.SetAlpha(0f);
     L1BronzeMedal.canvasRenderer.SetAlpha(0f);

     
    


     if(L1earnedGold == true)                             
    {
    L1GoldMedal.canvasRenderer.SetAlpha(1f);        //<---- ukaž zlatou jestli hráč dojel včas
    } 
       else if(L1earnedSilver == true)
    {
    L1SilverMedal.canvasRenderer.SetAlpha(1f);//<----  ukaž stříbrnou jestli hráč dojel včas
    } 
      else if(L1earnedBronze == true)
    {
    L1BronzeMedal.canvasRenderer.SetAlpha(1f); //<---- ukaž bronzovou jestli hráč dojel včas
    } 
      } 
      }

      private void LoadL2Medals(){
  if(FinishedL2 == true) {
     L2GoldMedal = GameObject.Find("GoldMedalL2").GetComponent<RawImage>();
          L2SilverMedal = GameObject.Find("SilverMedalL2").GetComponent<RawImage>();
          L2BronzeMedal = GameObject.Find("BronzeMedalL2").GetComponent<RawImage>();
             
               L2GoldMedal.canvasRenderer.SetAlpha(0f);
      L2SilverMedal.canvasRenderer.SetAlpha(0f);
     L2BronzeMedal.canvasRenderer.SetAlpha(0f);

 if(L2earnedGold == true)                             
    {
    L2GoldMedal.canvasRenderer.SetAlpha(1f);        //<---- ukaž zlatou jestli hráč dojel včas
    } 
       else if(L2earnedSilver == true)
    {
    L2SilverMedal.canvasRenderer.SetAlpha(1f);//<----  ukaž stříbrnou jestli hráč dojel včas
    } 
      else if(L2earnedBronze == true)
    {
    L2BronzeMedal.canvasRenderer.SetAlpha(1f); //<---- ukaž bronzovou jestli hráč dojel včas
    } 

  }
  
  
      }
        private void LoadL3Medals() { 
    if(FinishedL3 == true) //<---- jestli hráč dokončil Level 1
    {
  
  
         L3GoldMedal = GameObject.Find("GoldMedalL3").GetComponent<RawImage>();
          L3SilverMedal = GameObject.Find("SilverMedalL3").GetComponent<RawImage>();
          L3BronzeMedal = GameObject.Find("BronzeMedalL3").GetComponent<RawImage>();
             
               L3GoldMedal.canvasRenderer.SetAlpha(0f);
      L3SilverMedal.canvasRenderer.SetAlpha(0f);
     L3BronzeMedal.canvasRenderer.SetAlpha(0f);

     
    


     if(L3earnedGold == true)                             
    {
    L3GoldMedal.canvasRenderer.SetAlpha(1f);        //<---- ukaž zlatou jestli hráč dojel včas
    } 
       else if(L3earnedSilver == true)
    {
    L3SilverMedal.canvasRenderer.SetAlpha(1f);//<----  ukaž stříbrnou jestli hráč dojel včas
    } 
      else if(L3earnedBronze == true)
    {
    L3BronzeMedal.canvasRenderer.SetAlpha(1f); //<---- ukaž bronzovou jestli hráč dojel včas
    } 
      } 
      }
        private void LoadTMedals() { 
    if(FinishedT== true) //<---- jestli hráč dokončil Level 1
    {
  
  
         TGoldMedal = GameObject.Find("GoldMedalT").GetComponent<RawImage>();
          TSilverMedal = GameObject.Find("SilverMedalT").GetComponent<RawImage>();
          TBronzeMedal = GameObject.Find("BronzeMedalT").GetComponent<RawImage>();
             
               TGoldMedal.canvasRenderer.SetAlpha(0f);
      TSilverMedal.canvasRenderer.SetAlpha(0f);
     TBronzeMedal.canvasRenderer.SetAlpha(0f);

     
    


     if(TearnedGold == true)                             
    {
    TGoldMedal.canvasRenderer.SetAlpha(1f);        //<---- ukaž zlatou jestli hráč dojel včas
    } 
       else if(TearnedSilver == true)
    {
   TSilverMedal.canvasRenderer.SetAlpha(1f);//<----  ukaž stříbrnou jestli hráč dojel včas
    } 
      else if(TearnedBronze == true)
    {
    TBronzeMedal.canvasRenderer.SetAlpha(1f); //<---- ukaž bronzovou jestli hráč dojel včas
    } 
      } 
} 
  private void Start()
  {
  if(SceneManager.GetActiveScene().name.StartsWith("Menu"))
         { menuTimer = GameObject.FindObjectOfType<MenuTimer>();
             L1GoldMedal = GameObject.Find("GoldMedalL1").GetComponent<RawImage>();
          L1SilverMedal = GameObject.Find("SilverMedalL1").GetComponent<RawImage>();
          L1BronzeMedal = GameObject.Find("BronzeMedalL1").GetComponent<RawImage>();
             
               L1GoldMedal.canvasRenderer.SetAlpha(0f);
      L1SilverMedal.canvasRenderer.SetAlpha(0f);
     L1BronzeMedal.canvasRenderer.SetAlpha(0f);
        
           L2GoldMedal = GameObject.Find("GoldMedalL2").GetComponent<RawImage>();
          L2SilverMedal = GameObject.Find("SilverMedalL2").GetComponent<RawImage>();
          L2BronzeMedal = GameObject.Find("BronzeMedalL2").GetComponent<RawImage>();
             
               L2GoldMedal.canvasRenderer.SetAlpha(0f);
      L2SilverMedal.canvasRenderer.SetAlpha(0f);
     L2BronzeMedal.canvasRenderer.SetAlpha(0f);

           L3GoldMedal = GameObject.Find("GoldMedalL3").GetComponent<RawImage>();
          L3SilverMedal = GameObject.Find("SilverMedalL3").GetComponent<RawImage>();
          L3BronzeMedal = GameObject.Find("BronzeMedalL3").GetComponent<RawImage>();
             
               L3GoldMedal.canvasRenderer.SetAlpha(0f);
      L3SilverMedal.canvasRenderer.SetAlpha(0f);
     L3BronzeMedal.canvasRenderer.SetAlpha(0f);

       TGoldMedal = GameObject.Find("GoldMedalT").GetComponent<RawImage>();
          TSilverMedal = GameObject.Find("SilverMedalT").GetComponent<RawImage>();
          TBronzeMedal = GameObject.Find("BronzeMedalT").GetComponent<RawImage>();
             
               TGoldMedal.canvasRenderer.SetAlpha(0f);
      TSilverMedal.canvasRenderer.SetAlpha(0f);
     TBronzeMedal.canvasRenderer.SetAlpha(0f);
           LoadL3Medals();
           LoadL2Medals();
           LoadL1Medals();
           
           LoadL1MP();
           LoadL2MP();
           LoadL3MP();

           LoadTMedals();
         }

  }

  public void Tutorial()  {
   startLevel = true;
   sceneNumber = 1;
   menuTimer.timeToStart = 3;
   menuTimer.timer = 0;
   }   
     public void Menu()  {
  
 SceneManager.LoadScene(0);

   }   
     public void Level1()  {
 
startLevel = true;
   sceneNumber = 2;
      menuTimer.timeToStart = 3;
         menuTimer.timer = 0;
   }   
      public void Level2()  {
startLevel = true;
   sceneNumber = 3;
      menuTimer.timeToStart = 3;
         menuTimer.timer = 0;
   } 
         public void Level3()  {
startLevel = true;
   sceneNumber = 4;
      menuTimer.timeToStart = 3;
         menuTimer.timer = 0;
   } 
         public void Level1M()  {
startLevel = true;
   sceneNumber = 5;
      menuTimer.timeToStart = 3;
         menuTimer.timer = 0;
   } 
         public void Level2M()  {
startLevel = true;
   sceneNumber = 6;
      menuTimer.timeToStart = 3;
         menuTimer.timer = 0;
   } 
         public void Level3M()  {
startLevel = true;
   sceneNumber = 7;
      menuTimer.timeToStart = 3;
         menuTimer.timer = 0;
   } 
            public void Statistics()  {
 SceneManager.LoadScene(11);
  
 
   } 
               public void Tournament()  {
startLevel = true;
   sceneNumber = 12;
      menuTimer.timeToStart = 3;
         menuTimer.timer = 0;
  
 
   } 
   private void Update() {
            if (Input.GetKeyDown(KeyCode.Escape))
        {         SceneManager.LoadScene(0);
             
        }

  } 
}

