using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFishanim : MonoBehaviour
{
     private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
         mAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ArriveScale()
    {
        mAnimator.SetTrigger("Strigger");
        mAnimator.ResetTrigger("SRTrigger");
    }


    public void ReverseArriveScale()
    {
        mAnimator.ResetTrigger("Strigger");
        mAnimator.SetTrigger("SRTrigger");
    }

}
