using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class RandomValue : MonoBehaviour
{
    public Sprite[] Fleurs;
    public Image[] Commande;
    private int chiffreRandom = 0;

    public void commandeClient ()
    {
        Commande[0].sprite = Fleurs[chiffreRandom];
    }

    private void Start()
    {
        commandeClient();
    }
}
