using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public GameObject GameoverPanel;
    public int countdownMinutes = 3;
    private float countdownSeconds;
    private Text timeText;

    private void Start()
    {
        
        timeText = GetComponent<Text>();
        countdownSeconds = countdownMinutes * 60;
    }

    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"m\:ss");

        if (countdownSeconds <= 0)
        {
            GameoverPanel.SetActive(true);
            Destroy(this.gameObject);
       
        }
    }
}