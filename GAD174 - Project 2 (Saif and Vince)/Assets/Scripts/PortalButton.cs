using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalButton : MonoBehaviour
{
    [SerializeField] Material portalMaterial;

    void Start()
    {
        
   
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


    
}
