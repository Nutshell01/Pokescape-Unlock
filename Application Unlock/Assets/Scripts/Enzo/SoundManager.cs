using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] AudioClip[] _audioClips;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource.clip = _audioClips[0];
        _audioSource.loop = true;
        _audioSource.Play();
    }

    public void Phase2()
    {
        _audioSource.clip = _audioClips[1];
        _audioSource.loop = true;
        _audioSource.Play();
    }
    public void Phase3()
    {
        _audioSource.clip = _audioClips[2];
        _audioSource.loop = true;
        _audioSource.Play();
    }

    // Update is called once per frame

}
