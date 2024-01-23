using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip BGM;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.clip = BGM;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
