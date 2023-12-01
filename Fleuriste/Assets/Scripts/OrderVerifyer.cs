using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderVerifyer : MonoBehaviour
{

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Bouquet"){
            if (gameflow.bouquetValue == gameflow.orderValue[RandomValue.chiffreRandom]){
                Debug.Log("correct!");
            } else {
                Debug.Log("Incorrect!");
            }
        }
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
