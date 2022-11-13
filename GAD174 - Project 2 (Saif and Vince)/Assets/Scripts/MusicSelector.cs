using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelector : MonoBehaviour
{
    [SerializeField] AudioSource[] musicList;

    int PortalCount = 0;

    private void Start()
    {
        musicList[0].Play();
    }

    // Update is called once per frame
    void Update()
    {
     

        if (PortalCount == 0)
        {
            musicList[0].Play();
            musicList[1].Stop();
            musicList[2].Stop();
            musicList[3].Stop();

        }
        else if (PortalCount == 1)
        {
            musicList[0].Stop();
            musicList[1].Play();
            musicList[2].Stop();
            musicList[3].Stop();
        }
        else if (PortalCount == 2)
        {
            musicList[0].Stop();
            musicList[1].Stop();
            musicList[2].Play();
            musicList[3].Stop();
        }
    }

    public void ChangeMusic()
    {
        PortalCount++;
    }
}
