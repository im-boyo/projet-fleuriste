using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class RandomValue : MonoBehaviour
{
    public Sprite[] Fleurs;
    public Image[] Commande;
    public Material[] Material;

    public void commandeClient ()
    {
        int chiffreRandom = Random.Range(0, 2);
        Commande[0].sprite = Fleurs[chiffreRandom];
    }

    private void Start()
    {
        commandeClient();
    }
}
