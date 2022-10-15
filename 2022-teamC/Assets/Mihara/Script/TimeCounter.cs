using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public AudioClip GameOverSound;
    private AudioSource audioSource;
    public GameObject GameoverPanel;
    public int countdownMinutes = 3;
    public float countdownSeconds;
    private Text timeText;
    bool isCalledOnce = false;

    private void Start()
    {
        
        timeText = GetComponent<Text>();
        countdownSeconds = countdownMinutes * 60;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"m\:ss");

        if ((countdownSeconds <= 0) && (!isCalledOnce))
        {
            GameoverPanel.SetActive(true);
            audioSource.PlayOneShot(GameOverSound);
            //ゲームオーバーの音を鳴らす
            isCalledOnce = true;
        }
    }
}