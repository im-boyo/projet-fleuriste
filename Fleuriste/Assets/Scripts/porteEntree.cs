using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public Animator mainDoor;
    public GameObject mainDoorSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainDoorArea")
        {
            mainDoor.Play("Ouverture");
            mainDoorSound.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainDoorArea")
        {
            mainDoor.Play("fermeture");
            mainDoorSound.SetActive(false);
        }
    }

}
