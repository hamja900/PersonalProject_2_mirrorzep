using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepSound : MonoBehaviour
{
    [SerializeField] private AudioClip footSteps;
    [SerializeField] private AudioSource audioSource;

    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    public void CreateSoundFootstep()
    {
        if (animator.GetBool("IsWalk"))
        {
            audioSource.PlayOneShot(footSteps);
        }
        else
        {
            audioSource.Stop();
        }
    }
}
