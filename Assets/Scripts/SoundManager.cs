using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource ambientSource;
    [SerializeField] private AudioSource chaseSource;

    private void Awake()
    {
        Instance = this;
    }
    public void PlayAmbient()
    {
        if (!ambientSource.isPlaying)
        {
            ambientSource.Play();
        }

        chaseSource.Stop();
    }

    public void PlayChase()
    {
        if (!chaseSource.isPlaying)
        {
            chaseSource.Play();
        }

        ambientSource.Stop();
    }
}
