using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowVolume : MonoBehaviour
{
    [SerializeField] GameObject VolumeSlider;

    bool SliderIsOpen = false;

    private void Start()
    {
        VolumeSlider.SetActive(false);
    }

    public void VolumeSliderFunction()
    {
        if(SliderIsOpen == false)
        {
            SliderIsOpen = true;
            VolumeSlider.SetActive(true);
        }
        else if(SliderIsOpen == true)
        {
            SliderIsOpen = false;
            VolumeSlider.SetActive(false);
        }
    }

}
