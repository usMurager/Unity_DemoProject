using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time;
    private TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        text.text = FormatTime();
    }

    private string FormatTime()
    {
        int seconds = (int)time % 60;
        int minutes = (int)(time / 60);

        string secondsString = seconds.ToString();
        if (seconds < 10)
        {
            secondsString = 0 + secondsString;
        }
        
        string minutesString = minutes.ToString();
        if (minutes < 10)
        {
            minutesString = 0 + minutesString;
        }

        return minutesString + ":" + secondsString;
    }
}
