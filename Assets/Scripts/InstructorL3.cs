using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InstuctorL3 : MonoBehaviour
{        public List<string> listOfInstructorL3 = new List<string>();
       public CheckpointList checkpointlist;
        public TextMeshProUGUI InstructorText;
    void Start()
    {
         checkpointlist  = GameObject.FindObjectOfType<CheckpointList>();
          listOfInstructorL3.Add("");
         listOfInstructorL3.Add("Instructor: 50 km/h straight and 20 km/h in the turn");
           listOfInstructorL3.Add("Instructor: 50 km/h straight and 20 km/h in the turn");
              listOfInstructorL3.Add("Instructor: 50 km/h straight and 20 km/h in the turn");
                listOfInstructorL3.Add("Instructor: Max");
                 listOfInstructorL3.Add("Instructor: Max");
    }

    void Update()
    {
           InstructorText.text = listOfInstructorL3[checkpointlist.currentCheckpoint];
    }
}