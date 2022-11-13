using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalChanger : MonoBehaviour
{
    [SerializeField] Material[] portalColors;
    Renderer rend;
    void Start()
    {
        rend= GetComponent<Renderer>();
        rend.enabled= true;
        rend.sharedMaterial = portalColors[0];
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           rend = GetComponent<Renderer>();
           rend.enabled = true;
           rend.sharedMaterial = portalColors[1];
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rend = GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = portalColors[2];
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rend = GetComponent<Renderer>();
            rend.enabled = true;
            rend.sharedMaterial = portalColors[0];
        }
    }
}
