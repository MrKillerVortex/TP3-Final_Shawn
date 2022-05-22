using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class VolumeScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject audioMenu;
    public Slider sliderGeneral;
    public AudioMixer audioMixer;
    public Slider sliderMusique;

    // Start is called before the first frame update
    void Start()
    {
        sliderGeneral.onValueChanged.AddListener(sliderVolGeneral_OnValueChanged);
        sliderMusique.onValueChanged.AddListener(sliderVolMusique_OnValueChanged);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void sliderVolGeneral_OnValueChanged(float value)
    {
        audioMixer.SetFloat("GainGeneral", Mathf.Log(value) * 20f);
    }
    void sliderVolMusique_OnValueChanged(float value)
    {
        audioMixer.SetFloat("GainMusique", Mathf.Log(value) * 20f);
    }

    public void RetournerVersMenuPause()
    {
        audioMenu.SetActive(false);
        pauseMenu.SetActive(true);

    }
}
