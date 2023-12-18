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
    public GameObject destroyerGameobject;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bouquet")
        {
            gameflow.bouquetValue += flowerValue;
            destroyerGameobject.SetActive(true);
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
            Debug.Log("Order Value " + gameflow.orderValue);
            if (doesItExist == 0)
            {
                doesItExist = 1;
                StartCoroutine("createPrefab");
            } else if (doesItExist == 1)
            {
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
