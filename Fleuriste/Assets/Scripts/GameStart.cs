using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{

    public Animator girl1;

    public void commencerJeu()
    {
        girl1.Play("WalkIn");
    }
}
