using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultAnimation : MonoBehaviour
{
    protected Animator animator;
    protected DefaultCharacterController controller;
    protected virtual void Awake()
    {
        animator =GetComponentInChildren<Animator>();
        controller = GetComponent<DefaultCharacterController>();
    }
}
