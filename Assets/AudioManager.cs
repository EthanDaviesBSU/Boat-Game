using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;

    public AudioClip propeller;
    public AudioClip subDrop;
    public AudioClip pickup1;
    public AudioClip pickup2;
    public AudioClip pickup3;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
