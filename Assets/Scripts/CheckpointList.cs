using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointList : MonoBehaviour
{   public List<Vector3> listOfCheckpoints = new List<Vector3>();
    public List<Quaternion> listOfCheckpointRotation = new List<Quaternion>();
    public int currentCheckpoint;
    public int maxCheckpoint;
    public GameObject carObject;
    private Rigidbody rb;
    public int timesTeleported;
      private float seconds;
    void Start()
    {  currentCheckpoint = 0;
       timesTeleported = 0;
        rb = GameObject.Find("Auto").GetComponent<Rigidbody>();
  
        if(SceneManager.GetActiveScene().name.StartsWith("Tutorial"))
         {
               maxCheckpoint = 2;

         }
             if(SceneManager.GetActiveScene().name.StartsWith("Level1") || SceneManager.GetActiveScene().name.StartsWith("TLevel1"))
         {
               maxCheckpoint = 4;

         }
                   if(SceneManager.GetActiveScene().name.StartsWith("Level2")||  SceneManager.GetActiveScene().name.StartsWith("TLevel2"))
         {
               maxCheckpoint = 5;

         }
                     if(SceneManager.GetActiveScene().name.StartsWith("Level3") ||  SceneManager.GetActiveScene().name.StartsWith("TLevel3"))
         {
               maxCheckpoint = 6;

         }
      
    }


    void Update()
    {seconds += Time.deltaTime;
           
       
        if(Input.GetKey(KeyCode.R) && seconds > 1f )               //<------- Hráč zmáčkl R
          { 
                if (listOfCheckpoints.Count > 0)        //<---- Kontrola jestli hráč projel nějakým checkpointem
            {
            Vector3 newPositionOfCar = listOfCheckpoints[currentCheckpoint - 1];     
            carObject.transform.position = newPositionOfCar;       //<------ Nová pozice auta podle checkpointu
            
               Quaternion   eulerRotation = listOfCheckpointRotation[currentCheckpoint - 1];       //<------ Nová rotace auta podle checkpointu
                carObject.transform.rotation =eulerRotation;
          rb.velocity = Vector3.zero;              //<------ Vynulování rychlosti auta
          timesTeleported++;
          seconds = 0;
            }
          }
    }
}
