using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Out : MonoBehaviour
{
    public AudioClip GameOverSound;
    private AudioSource audioSource;
    public GameObject GameoverPanel;
    public bool GameOverFlag = false;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
   
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Tumeru")
        {
            GameoverPanel.SetActive(true);
            audioSource.PlayOneShot(GameOverSound);
            //ゲームオーバーの音を鳴らす
            GameOverFlag = true;



        }
    }
}
