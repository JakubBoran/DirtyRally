using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Checkpoint : MonoBehaviour
{    private Collider collider;
    private TextMeshProUGUI checktext;
     public CheckpointList checkpointlist;

    void Start()
    {  collider = GetComponent<Collider>();
         checkpointlist  = GameObject.FindObjectOfType<CheckpointList>();
               checktext = GameObject.Find("CheckpointText").GetComponent<TextMeshProUGUI>();
    }

   
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col)
    {
          if (col.gameObject.name == "Auto")
            {
              checkpointlist.currentCheckpoint++;
              Vector3 checkpointPosition = transform.position;
              checkpointlist.listOfCheckpoints.Add(checkpointPosition);
                    
                     Quaternion checkpointRotation = transform.rotation;
                checkpointlist.listOfCheckpointRotation.Add(checkpointRotation);
              collider.enabled = false;
                 checktext.text = checkpointlist.currentCheckpoint+  " / " + checkpointlist.maxCheckpoint;
            }
    
    
    
    }  

}
