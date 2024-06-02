using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        // if(mAnimator != null){
        //     if(Input.GetKeyDown(KeyCode.o)){
        //         mAnimator.SetTrigger("cellTrigger");
        //     }
        // }
        
    }

    public void ArriveScale()
    {
        mAnimator.SetTrigger("cellTrigger");
        mAnimator.ResetTrigger("cellReverse");
    }


    public void ReverseArriveScale()
    {
        mAnimator.ResetTrigger("cellTrigger");
        mAnimator.SetTrigger("cellReverse");
    }

}
