using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InstuctorL1 : MonoBehaviour
{        public List<string> listOfInstructor = new List<string>();
       public CheckpointList checkpointlist;
        public TextMeshProUGUI InstructorText;
    void Start()
    {
         checkpointlist  = GameObject.FindObjectOfType<CheckpointList>();
         listOfInstructor.Add("Instructor: 30 Km/H");
             listOfInstructor.Add("Instructor: 20 Km/H");
                listOfInstructor.Add("Instructor: 10 Km/H");
                 listOfInstructor.Add("Instructor: 40 Km/H");
    }

    void Update()
    {
           InstructorText.text = listOfInstructor[checkpointlist.currentCheckpoint - 1];
    }
}
