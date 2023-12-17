using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderVerifyer : MonoBehaviour
{
    public Animator girl1;
    public Animator myAnimator;
    public Animator nextAnimator;

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Bouquet"){
            if (gameflow.bouquetValue == gameflow.orderValue){
                Debug.Log("correct!");
                StartCoroutine("animLeave");
            } else {
                Debug.Log("Incorrect!");
            }
        } else if (other.tag == "NextClient")
        {
            StartCoroutine("animNext");
        }
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

    public void commencerJeu()
    {
        girl1.Play("WalkIn");
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
