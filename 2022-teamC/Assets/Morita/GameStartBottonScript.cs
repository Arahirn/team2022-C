using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartBottonScript : MonoBehaviour
{
    public AudioClip BubbleSound;
    private AudioSource audioSource;
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PushButton()
    {
            audioSource.PlayOneShot(BubbleSound);
            Panel.SetActive(true);
    
    }
}
