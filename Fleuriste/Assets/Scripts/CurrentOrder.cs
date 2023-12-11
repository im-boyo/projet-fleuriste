using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CurrentOrder : MonoBehaviour
{
    public int flowerValue;
    public GameObject flowerPrefab;
    private Vector3 flowerPosition;
    private Quaternion flowerRotation;
    public int doesItExist = 0;
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
        flowerRotation = transform.rotation;
    }
      private IEnumerator createPrefab()
    {
        yield return new WaitForSeconds(1f);
        doesItExist = 0;
        Instantiate(flowerPrefab, flowerPosition, flowerRotation);
        yield return new WaitForSeconds(1f);
        Debug.Log(doesItExist);
        yield break;
    }
  private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bouquet")
        {
            gameflow.bouquetValue -= flowerValue;
            Debug.Log(gameflow.bouquetValue + "  " + gameflow.orderValue);
        } else if (other.tag == "Pot")
        {
            Debug.Log(doesItExist);
            if (doesItExist == 0)
            {
                doesItExist = 1;
                Debug.Log("It's out");
                StartCoroutine("createPrefab");
            } else if (doesItExist == 1)
            {
                Debug.Log("Gyat");
                doesItExist = 0;
            }
        }
    }


   

    // Update is called once per frame
    void Update()
    {
        flowerPrefab.GetComponent<Rigidbody>().isKinematic = false;
    }
}
