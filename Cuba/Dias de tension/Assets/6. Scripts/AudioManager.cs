using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer master;
    public AudioSource Interferencia, Estatica;

    [Range(-80,10)]
    public float masterVol;
    public Slider masterSlider;

    public static AudioManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        PlayAudio(Interferencia);
        masterSlider.value = masterVol;

        masterSlider.minValue = -80;
        masterSlider.maxValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        MasterVolume();
    }

    public void MasterVolume()
    {
        master.SetFloat("Master",masterSlider.value);
    }

    public void PlayAudio(AudioSource audio)
    {
        audio.Play();
    }
}
