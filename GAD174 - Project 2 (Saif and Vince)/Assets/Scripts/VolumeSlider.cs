using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
        audioSource.volume = slider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VolumeSound()
    {
        audioSource.volume = slider.value;
    }
}
