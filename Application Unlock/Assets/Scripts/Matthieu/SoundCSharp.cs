using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCSharp : MonoBehaviour
{
    #region SerializeField
    [SerializeField] private AudioSource audioButton;
    [SerializeField] private AudioSource audioBuzzer;
    [SerializeField] private AudioSource audioValidation;
    [SerializeField] private AudioSource audioFire;
    [SerializeField] private AudioSource audioChestHit;
    [SerializeField] private AudioSource audioChestBreak;
    [SerializeField] private AudioSource audioDoorOpen;
    [SerializeField] private AudioSource audioFlute;
    [SerializeField] private AudioSource audioLamp;
    [SerializeField] private AudioSource audioPokeballWobble;
    [SerializeField] private AudioSource audioPokeballLand;
    [SerializeField] private AudioSource audioPokeballCatch;
    [SerializeField] private AudioSource audioPullRock;
    #endregion

    private void PlaySound(AudioSource audioSource)
    {
        if(audioSource!=null)
        {
            audioSource.Play();
            if(audioSource.outputAudioMixerGroup==null) Debug.Log("Missing assigned audio mixer at " + audioSource + " audioSource !");
        }
        else Debug.Log("Missing audio source !!!");
    }
    #region all PlayAudioS
    public void PlayAudioSButton()
    {
        PlaySound(audioButton);
    }
    public void PlayAudioSBuzzer()
    {
        PlaySound(audioBuzzer);
    }
    public void PlayAudioSValidation()
    {
        PlaySound(audioValidation);
    }
    public void PlayAudioSFire()
    {
        PlaySound(audioFire);
    }
    public void PlayAudioSChestHit()
    {
        PlaySound(audioChestHit);
    }
    public void PlayAudioSChestBreak()
    {
        PlaySound(audioChestBreak);
    }
    public void PlayAudioSDoorOpen()
    {
        PlaySound(audioDoorOpen);
    }
    public void PlayAudioSFlute()
    {
        PlaySound(audioFlute);
    }
    public void PlayAudioSLamp()
    {
        PlaySound(audioLamp);
    }
    public void PlayAudioSPokeballWobble()
    {
        PlaySound(audioPokeballWobble);
    }
    public void PlayAudioSPokeballLand()
    {
        PlaySound(audioPokeballLand);
    }
    public void PlayAudioSPokeballCatch()
    {
        PlaySound(audioPokeballCatch);
    }
    public void PlayAudioSPullRock()
    {
        PlaySound(audioPullRock);
    }
    #endregion
}