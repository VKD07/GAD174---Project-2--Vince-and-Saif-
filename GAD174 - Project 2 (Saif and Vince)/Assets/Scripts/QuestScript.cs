using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestScript : MonoBehaviour
{
    [SerializeField] GameObject QuestBox;
    CanvasGroup QuestBoxTransition;
    bool QuestBoxIsOpen = false;
    bool OpenSound = false;
    bool CloseSound = false;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip ButtonSound;
    [SerializeField] AudioClip QuestSound;

    [SerializeField] Material book;

    void Start()
    {
        QuestBoxTransition = QuestBox.GetComponent<CanvasGroup>();
        QuestBoxTransition.alpha = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if(QuestBoxIsOpen == true)
        {
            if (QuestBoxTransition.alpha < 1)
            {
                QuestBoxTransition.alpha += Time.deltaTime;
            }
        }
        else
        {
            if (QuestBoxTransition.alpha >= 0)
            {
                QuestBoxTransition.alpha -= Time.deltaTime;
            }
        }
      
    }

    public void OpenQuest()
    {
        if(OpenSound == false)
        {
            OpenSound = true;
            CloseSound = false;
            audioSource.PlayOneShot(ButtonSound, 1f);
            audioSource.PlayOneShot(QuestSound);
        }
      
        QuestBoxIsOpen = true;
    }

    public void CloseQuest()
    {
        if (CloseSound == false)
        {
            CloseSound = true;
            OpenSound = false;
            audioSource.PlayOneShot(ButtonSound, 1f);
        }
        QuestBoxIsOpen = false;
    }

    public void HighlightBook()
    {
        book.EnableKeyword("_EMISSION");
    }
    public void DisableHighlightBook()
    {
        book.DisableKeyword("_EMISSION");
    }



}
