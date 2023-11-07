using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomValue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void RandomColor() {
        int randomNb = Random.Range(0, 2);
        Debug.Log($"{randomNb}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
