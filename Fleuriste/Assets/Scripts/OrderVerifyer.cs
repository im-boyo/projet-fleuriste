using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderVerifyer : MonoBehaviour
{
    public Animator girl1;
    public Animator myAnimator;
    public Animator nextAnimator;
    public Animator lampAnimator;
    public int winCondition = 0;

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Bouquet"){
            if (gameflow.bouquetValue == gameflow.orderValue){
                Debug.Log("correct!");
                StartCoroutine("animLeave");
                gameflow.bouquetValue = 0;
            } else {
                Debug.Log("Incorrect!");
                gameflow.bouquetValue = 0;
            }
        } else if (other.tag == "NextClient")
        {
            StartCoroutine("animNext");
            winCondition += 1;
            if (winCondition == 6)
            {
                gameWin();
            }
        }
    }

    private void gameWin()
    {
        
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
