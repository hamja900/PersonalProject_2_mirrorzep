using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepSound : MonoBehaviour
{

    //파티클시스템을 응용해서 걷는 사운드를 넣으려고 했으나 적용안됨

    [SerializeField] private bool createSoundOnWalk=true;
    [SerializeField] private AudioClip footSteps;
    [SerializeField] private AudioSource audioSource;

    public void CreateSoundFootstep()
    {
        if (createSoundOnWalk)
        {
            audioSource.PlayOneShot(footSteps);
        }
    }
}
