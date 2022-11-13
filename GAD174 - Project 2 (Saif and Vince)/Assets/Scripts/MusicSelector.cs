using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSelector : MonoBehaviour
{
    [SerializeField] AudioSource[] musicList;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            musicList[0].Stop();
            musicList[1].Play();
            musicList[2].Stop();
            musicList[3].Stop();

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            musicList[0].Stop();
            musicList[1].Stop();
            musicList[2].Play();
            musicList[3].Stop();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            musicList[0].Play();
            musicList[1].Stop();
            musicList[2].Stop();
            musicList[3].Stop();
        }
    }
}
