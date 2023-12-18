using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class RandomValue : MonoBehaviour
{
    public Sprite[] Fleurs;
    public Image[] Commande;
    public GameObject OrderCanvas;
    public static int randomNumber1;
    public static int randomNumber2;
    public static int randomNumber3;
    public static int randomNumber4;
    public static int randomNumber5;
    public static int randomNumber6;
    public GameObject orderImage1;
    public GameObject orderImage2;
    public GameObject orderImage3;
    public GameObject orderImage4;
    public GameObject orderImage5;
    private int chiffreRandom1;
    private int chiffreRandom2;
    private int chiffreRandom3;
    private int chiffreRandom4;
    private int chiffreRandom5;

    private IEnumerator showOrder()
    {
        yield return new WaitForSeconds(1f);
        chiffreRandom1 = Random.Range(0, 5);
        if (chiffreRandom1 == 0)
        {
            gameflow.orderValue += 3;
        } else if (chiffreRandom1 == 1)
        {
            gameflow.orderValue += 30;
        } else if (chiffreRandom1 == 2)
        {
            gameflow.orderValue += 300;
        } else if (chiffreRandom1 == 3)
        {
            gameflow.orderValue += 3000;
        } else if (chiffreRandom1 == 4) 
        { 
            gameflow.orderValue += 30000;
        }
        Commande[0].sprite = Fleurs[chiffreRandom1];
        orderImage1.SetActive(true);
        yield return new WaitForSeconds(1f);
        chiffreRandom2 = Random.Range(0, 5);
        if (chiffreRandom2 == 0)
        {
            gameflow.orderValue += 3;
        }
        else if (chiffreRandom2 == 1)
        {
            gameflow.orderValue += 30;
        }
        else if (chiffreRandom2 == 2)
        {
            gameflow.orderValue += 300;
        }
        else if (chiffreRandom2 == 3)
        {
            gameflow.orderValue += 3000;
        }
        else if (chiffreRandom2 == 4)
        {
            gameflow.orderValue += 30000;
        }
        Commande[1].sprite = Fleurs[chiffreRandom2];

        orderImage2.SetActive(true);
        yield return new WaitForSeconds(1f);
        chiffreRandom3 = Random.Range(0, 5);
        if (chiffreRandom3 == 0)
        {
            gameflow.orderValue += 3;
        }
        else if (chiffreRandom3 == 1)
        {
            gameflow.orderValue += 30;
        }
        else if (chiffreRandom3 == 2)
        {
            gameflow.orderValue += 300;
        }
        else if (chiffreRandom3 == 3)
        {
            gameflow.orderValue += 3000;
        }
        else if (chiffreRandom3 == 4)
        {
            gameflow.orderValue += 30000;
        }
        Commande[2].sprite = Fleurs[chiffreRandom3];
        orderImage3.SetActive(true);
        yield return new WaitForSeconds(1f);
        chiffreRandom4 = Random.Range(0, 5);
        if (chiffreRandom4 == 0)
        {
            gameflow.orderValue += 3;
        }
        else if (chiffreRandom4 == 1)
        {
            gameflow.orderValue += 30;
        }
        else if (chiffreRandom4 == 2)
        {
            gameflow.orderValue += 300;
        }
        else if (chiffreRandom4 == 3)
        {
            gameflow.orderValue += 3000;
        }
        else if (chiffreRandom4 == 4)
        {
            gameflow.orderValue += 30000;
        }
        Commande[3].sprite = Fleurs[chiffreRandom4];
        orderImage4.SetActive(true);
        yield return new WaitForSeconds(1f);
        chiffreRandom5 = Random.Range(0, 5);
        if (chiffreRandom5 == 0)
        {
            gameflow.orderValue += 3;
        }
        else if (chiffreRandom5 == 1)
        {
            gameflow.orderValue += 30;
        }
        else if (chiffreRandom5 == 2)
        {
            gameflow.orderValue += 300;
        }
        else if (chiffreRandom5 == 3)
        {
            gameflow.orderValue += 3000;
        }
        else if (chiffreRandom5 == 4)
        {
            gameflow.orderValue += 30000;
        }
        Commande[4].sprite = Fleurs[chiffreRandom5];
        orderImage5.SetActive(true);
        yield break;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "StartOrder")
        {
            OrderCanvas.SetActive(true);
            StartCoroutine("showOrder");
            Debug.Log("Capsule in");
        }
    }

        private void OnTriggerExit(Collider other)
    {
        if(other.tag == "StartOrder")
        {
            OrderCanvas.SetActive(false);
            gameflow.orderValue = 0;
            orderImage1.SetActive(false);
            orderImage2.SetActive(false);
            orderImage3.SetActive(false);
            orderImage4.SetActive(false);
            orderImage5.SetActive(false);
        } 
    }

        private void Start()
    {

    }



}
