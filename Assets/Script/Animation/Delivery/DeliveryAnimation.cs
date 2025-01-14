﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*/

/// <summary>
///
/// </summary>

public class DeliveryAnimation : MonoBehaviour, AnimationInterface
{
    public Animator deliveryAnimator;

    public void Action(string action)
    {
        switch (action)
        {
            case "Active":
                this.Active();
                break;
            case "Boom":
                this.Boom();
                break;
            default:
                Debug.LogError("action is error");
                return;
        }
    }

    public void Boom()
    {
        this.deliveryAnimator.SetTrigger("Boom");
    }

    public void Active()
    {
        this.deliveryAnimator.SetTrigger("Active");
    }
}
