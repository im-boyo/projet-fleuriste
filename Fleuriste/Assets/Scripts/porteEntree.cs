using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator mainDoor;

    public void OnTriggerEnter(Collider other)
    {
        if( other.tag == "MainDoorArea")
        {
            mainDoor.Play("Ouverture");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainDoorArea")
        {
            mainDoor.Play("fermeture");
        }
    }

}
