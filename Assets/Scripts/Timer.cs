using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timeText;
    float time;
    bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        timeText.text = time.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            time += Time.deltaTime;
            timeText.text = time.ToString("F2");

        }



    }
    public void SetIsPlaying(bool state)
    {
        isPlaying = state;

    }
}
