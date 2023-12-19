using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinVerify : MonoBehaviour
{
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

    public void gameWin()
    {
        Debug.Log(OrderVerifyer.winCondition);
        if (OrderVerifyer.winCondition == 1)
        {
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
            OrderVerifyer.winCondition = 0;
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
