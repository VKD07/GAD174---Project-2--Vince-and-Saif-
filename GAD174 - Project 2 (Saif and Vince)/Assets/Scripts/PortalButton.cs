using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalButton : MonoBehaviour
{
    [SerializeField] Material portalMaterial;

    [SerializeField] Renderer portalEffect;

    [SerializeField] Material[] PortalColors;
    int PortalCount = 0;

    [SerializeField] AudioSource portalAudioSource;
    [SerializeField] AudioClip [] PortalMusic;
    [SerializeField] AudioClip PortalChangeSound;
   

   

    void Start()
    {
        portalEffect.enabled = true;
        portalEffect.sharedMaterial = PortalColors[PortalCount];
       
       
   
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PortalHighlight()
    {
        portalMaterial.SetColor("_EmissionColor", Color.white);
    }
    public void PortalDisableHighligth()
    {
        portalMaterial.SetColor("_EmissionColor", new Color(87,69,255) * 0.01f);
     
    }

    public void PortalColorEffect()
    {
        portalAudioSource.PlayOneShot(PortalChangeSound);
    
        if(PortalCount != 2)
        {
            PortalCount++;
        }
        else
        {
            PortalCount = 0;
        }

        portalEffect.sharedMaterial = PortalColors[PortalCount];

        portalAudioSource.clip = PortalMusic[PortalCount];
        portalAudioSource.Play();

        
    }
    
}
