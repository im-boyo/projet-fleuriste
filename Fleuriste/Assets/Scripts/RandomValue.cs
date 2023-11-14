using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class RandomValue : MonoBehaviour
{
    public Sprite[] Fleurs;
    public Image[] Commande;
    public Material[] materials;
    public GameObject Button;
    public MeshRenderer meshRenderer;



        public void commandeClient ()
    {
        int chiffreRandom = Random.Range(0, 2);
        Commande[0].sprite = Fleurs[chiffreRandom];
        meshRenderer.material = materials[chiffreRandom];
    }

        private void Start()
    {
        commandeClient();
        
    }

}
