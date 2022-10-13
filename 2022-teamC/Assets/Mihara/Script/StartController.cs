using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public AudioClip BubbleSound;
    private AudioSource audioSource;
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PushButton()
    {
        StartCoroutine("SceneChangeManager1");
        
    }
    private IEnumerator SceneChangeManager1()
    {
        audioSource.PlayOneShot(BubbleSound);
        //�A�̉���炷
        Panel.SetActive(true);
        //�t�F�[�h�A�E�g����
        yield return new WaitForSeconds(2.0f);
        // 2�b�҂�
        SceneManager.LoadScene("Game");

    }
}