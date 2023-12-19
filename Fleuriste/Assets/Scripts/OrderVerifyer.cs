using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderVerifyer : MonoBehaviour
{
    public Animator girl1;
    public Animator myAnimator;
    public Animator nextAnimator;

    public static int winCondition = 0;

    public Animator lampAnimator1;
    public Animator lampAnimator2;
    public Animator lampAnimator3;
    public Animator lampAnimator4;
    public Animator lampAnimator5;
    public Animator lampAnimator6;
    public Animator lampAnimator7;
    public Animator lampAnimator8;
    public Animator lampAnimator9;

    public GameObject winMenu;
    public AudioSource winSound;


    private void OnTriggerEnter(Collider other){
        if(other.tag == "Bouquet"){
            if (gameflow.bouquetValue == gameflow.orderValue){
                StartCoroutine("animLeave");
                gameflow.bouquetValue = 0;
            } else {
                gameflow.bouquetValue = 0;
            }
        } else if (other.tag == "NextClient")
        { 
            winCondition += 1;
            if (winCondition < 6)
            {
                StartCoroutine("animNext");
            } else
            {
                Debug.Log(winCondition);
                    Debug.Log("Heyyy");
                    lampAnimator1.Play("winLights");
                    lampAnimator2.Play("winLights");
                    lampAnimator3.Play("winLights");
                    lampAnimator4.Play("winLights");
                    lampAnimator5.Play("winLights");
                    lampAnimator6.Play("winLights");
                    lampAnimator7.Play("winLights");
                    lampAnimator8.Play("winLights");
                    lampAnimator9.Play("winLights");

                    winMenu.SetActive(true);
                    winSound.Play();
                    winCondition = 0;
            }
        }
    }

    public void stopAnimations()
    {
        lampAnimator1.Play("stopLights");
        lampAnimator2.Play("stopLights");
        lampAnimator3.Play("stopLights");
        lampAnimator4.Play("stopLights");
        lampAnimator5.Play("stopLights");
        lampAnimator6.Play("stopLights");
        lampAnimator7.Play("stopLights");
        lampAnimator8.Play("stopLights");
        lampAnimator9.Play("stopLights");
    }

    private IEnumerator animLeave()
    {
        yield return new WaitForSeconds(1f);
        myAnimator.Play("WalkOut");
        yield break;
    }

    private IEnumerator animNext()
    {
        yield return new WaitForSeconds(5f);
        nextAnimator.Play("WalkIn");
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
