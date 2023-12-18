using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator mainDoor;
    public AudioSource mainDoorSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainDoorArea")
        {
            mainDoor.Play("Ouverture");
            mainDoorSound.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainDoorArea")
        {
            mainDoor.Play("fermeture");
        }
    }

}
