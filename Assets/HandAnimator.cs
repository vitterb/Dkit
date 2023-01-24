using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimator : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public Animator handAnimator;
    public InputActionProperty gripAnimationAction;
    void Start()
    {

    }
    void Update()
    {
        float triggervalue = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggervalue);

        float griptrigger = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", griptrigger);
    }
}
