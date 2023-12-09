using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentOrder : MonoBehaviour
{
    public int flowerValue;
    public GameObject flowerPrefab;
    private Vector3 flowerPosition;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bouquet")
        {
            gameflow.bouquetValue += flowerValue;
            Debug.Log(gameflow.bouquetValue + "  " + gameflow.orderValue);
        }
    }
    void Start()
    {
        flowerPosition = transform.position;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bouquet")
        {
            gameflow.bouquetValue -= flowerValue;
            Debug.Log(gameflow.bouquetValue + "  " + gameflow.orderValue);
        } else if (other.tag == "Pot")
        {
            GameObject flowerPrefabCopy = Instantiate(flowerPrefab, flowerPosition, Quaternion.identity);
            flowerPrefabCopy.GetComponent<Rigidbody>().isKinematic = false;
            Debug.Log("It's out");
        }
    }

   

    // Update is called once per frame
    void Update()
    {

    }
}
