using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
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
        mAnimator.SetTrigger("SphereTrigger");
        mAnimator.ResetTrigger("ReverseTrigger");
    }


    public void ReverseArriveScale()
    {
        mAnimator.ResetTrigger("SphereTrigger");
        mAnimator.SetTrigger("ReverseTrigger");
    }

}
