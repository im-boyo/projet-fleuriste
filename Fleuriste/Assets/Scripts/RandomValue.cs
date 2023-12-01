using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class RandomValue : MonoBehaviour
{
    public Sprite[] Fleurs;
    public Image[] Commande;
    public GameObject Button;
    public MeshRenderer meshRenderer;
    public GameObject OrderCanvas;
    public static int randomNumber;


        public void commandeClient ()
    {
        int chiffreRandom = Random.Range(0, 2);
        randomNumber = chiffreRandom;
        Commande[0].sprite = Fleurs[chiffreRandom];
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "StartOrder")
        {
            OrderCanvas.SetActive(true);
            commandeClient();
        } 
    }

        private void OnTriggerExit(Collider other)
    {
        if(other.tag == "StartOrder")
        {
        OrderCanvas.SetActive(false);
        } 
    }

        private void Start()
    {

    }

}
