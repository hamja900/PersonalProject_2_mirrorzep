using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepSound : MonoBehaviour
{

    //��ƼŬ�ý����� �����ؼ� �ȴ� ���带 �������� ������ ����ȵ�

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
