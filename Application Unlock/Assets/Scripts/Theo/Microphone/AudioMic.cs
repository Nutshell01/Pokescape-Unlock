using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class AudioMic : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    AudioClip recording;
    AudioSource audioSource;
    private float startRecordingTime;
    public TextMeshProUGUI debug;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        //End the recording when the mouse comes back up, then play it
#if !UNITY_WEBGL ||UNITY_EDITOR
        Microphone.End("");
#endif
        //Trim the audioclip by the length of the recording
        AudioClip recordingNew = AudioClip.Create(recording.name, (int)((Time.time - startRecordingTime) * recording.frequency), recording.channels, recording.frequency, false);
        float[] data = new float[(int)((Time.time - startRecordingTime) * recording.frequency)];
        recording.GetData(data, 0);
        recordingNew.SetData(data, 0);
        this.recording = recordingNew;

        //Play recording
        // audioSource.clip = recording;
        // audioSource.Play();

        


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Get the max frequency of a microphone, if it's less than 44100 record at the max frequency, else record at 44100
        int minFreq = 0;
        int maxFreq = 44100;
        int freq = 44100;
#if !UNITY_WEBGL || UNITY_EDITOR
        Microphone.GetDeviceCaps("", out minFreq, out maxFreq);
#endif
        if (maxFreq < 44100)
            freq = maxFreq;

        //Start the recording, the length of 300 gives it a cap of 5 minutes
#if !UNITY_WEBGL || UNITY_EDITOR
        recording = Microphone.Start("", false, 300, 44100);
#endif
        startRecordingTime = Time.time;
    }

}
