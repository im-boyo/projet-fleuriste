using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentOrder : MonoBehaviour
{
    public int flowerValue;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bouquet")
        {
            gameflow.bouquetValue += flowerValue;
            Debug.Log(gameflow.bouquetValue + "  " + gameflow.orderValue);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bouquet")
        {
            gameflow.bouquetValue -= flowerValue;
            Debug.Log(gameflow.bouquetValue + "  " + gameflow.orderValue);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
