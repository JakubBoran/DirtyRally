using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InstuctorL2 : MonoBehaviour
{        public List<string> listOfInstructorL2 = new List<string>();
       public CheckpointList checkpointlist;
        public TextMeshProUGUI InstructorText;
    void Start()
    {
         checkpointlist  = GameObject.FindObjectOfType<CheckpointList>();
          listOfInstructorL2.Add("");
         listOfInstructorL2.Add("Instructor: 40-30 km/h");
             listOfInstructorL2.Add("Instructor: 20 km/h");
                listOfInstructorL2.Add("Instructor: 15 km/h");
                 listOfInstructorL2.Add("Instructor: 25 km/h then Max to finale");
    }

    void Update()
    {
           InstructorText.text = listOfInstructorL2[checkpointlist.currentCheckpoint];
    }
}