using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameflow : MonoBehaviour
{
    public static int orderValue;        
    public static int bouquetValue = 0;
    public Animator girl1;

    public void commencerJeu()
    {
        girl1.Play("WalkIn");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
