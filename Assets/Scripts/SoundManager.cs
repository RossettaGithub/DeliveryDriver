using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Toggle toggle;
    AudioSource audioSource;
    void Start()
    {
        //toggle = GetComponent<Toggle>();
        audioSource = GetComponent<AudioSource>();
    }

    public void OnChange()
    {
        if(toggle.isOn)
        {
          audioSource.Play();

        }
        else
        {
            audioSource.Stop();

        }





    }
}
