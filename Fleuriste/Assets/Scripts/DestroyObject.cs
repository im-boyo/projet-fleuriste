using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject self;
    public GameObject destroyerGameobject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainDoorArea")
        {
            StartCoroutine("Destruction");
        }
    }

    private IEnumerator Destruction()
    {
        yield return new WaitForSeconds(1f);
        destroyerGameobject.SetActive(true);
        yield return new WaitForSeconds(1f);
        Destroy(self);
        gameflow.bouquetValue = 0;
        yield break;
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
