using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] AudioSource PortalMusic;
    [SerializeField] AudioSource QuestSound;
    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        PortalMusic.volume = slider.value;  
        QuestSound.volume = slider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeSound()
    {
        QuestSound.volume = slider.value;
        PortalMusic.volume = slider.value;
    }
}
