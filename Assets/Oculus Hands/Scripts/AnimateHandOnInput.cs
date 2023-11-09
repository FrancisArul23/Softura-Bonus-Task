using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{

    public InputActionProperty pinchAnim;
    public InputActionProperty gripAnim;
    public Animator hAnimator;

   


    void Start()
    {
        
    }

    
    void Update()
    {
        float triggerVal =  pinchAnim.action.ReadValue<float>();
        //Debug.Log("triggerVal : " + triggerVal);
        hAnimator.SetFloat("Trigger", triggerVal);

        float gripVal = gripAnim.action.ReadValue<float>();
        //Debug.Log("gripVal : " + gripVal);
        hAnimator.SetFloat("Grip", gripVal);
    
      
    }
    
    
    
}







