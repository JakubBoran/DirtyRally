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
    
    void Start()
    {  currentCheckpoint = 0;
        rb = GameObject.Find("Auto").GetComponent<Rigidbody>();
  
        if(SceneManager.GetActiveScene().name.StartsWith("Tutorial"))
         {
               maxCheckpoint = 2;

         }
             if(SceneManager.GetActiveScene().name.StartsWith("Level1"))
         {
               maxCheckpoint = 4;

         }
      
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.R))
          { 
                if (listOfCheckpoints.Count > 0)
            {
            Vector3 newPositionOfCar = listOfCheckpoints[currentCheckpoint - 1];
            carObject.transform.position = newPositionOfCar;
            
               Quaternion   eulerRotation = listOfCheckpointRotation[currentCheckpoint - 1];
                carObject.transform.rotation =eulerRotation;
          rb.velocity = Vector3.zero;
            }
          }
    }
}
