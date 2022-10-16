using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    public AudioClip bgm1;
    private AudioSource audioSource;
    public GameObject GameoverPanel;
    public TimeCounter TC;
    public Out Outscript1;
    public Out Outscript2;
    public Out Outscript3;
    bool isCalledOnce = true;
    public delegate void Change();
    string nextScene;
    string beforeScene;

    // Start is called before the first frame update
    void Start()
    {
        beforeScene = "Title";
        nextScene = SceneManager.GetActiveScene().name;
        audioSource = gameObject.GetComponent<AudioSource>();
        GameoverPanel = GameObject.Find("Panel"); //GameoverPanel���Ă����I�u�W�F�N�g��T��
        GameObject timer = GameObject.Find("Timer"); //Timer���Ă����I�u�W�F�N�g��T��
        TC = timer.GetComponent<TimeCounter>(); //�t���Ă���X�N���v�g���擾
        GameObject OS = GameObject.Find("OutStage"); //OutStage���Ă����I�u�W�F�N�g��T��
        Outscript1 = OS.GetComponent<Out>(); //�t���Ă���X�N���v�g���擾
        GameObject OSL = GameObject.Find("OutStageL"); //OutStageL���Ă����I�u�W�F�N�g��T��
        Outscript2 = OSL.GetComponent<Out>(); //�t���Ă���X�N���v�g���擾
        GameObject OSR = GameObject.Find("OutStageR"); //OutStageR���Ă����I�u�W�F�N�g��T��
        Outscript3 = OSR.GetComponent<Out>();�@//�t���Ă���X�N���v�g���擾
    }

    // Update is called once per frame
    void Update()
    {
        if ((TC.countdownSeconds <= 0) || (Outscript1.GameOverFlag == true) || (Outscript2.GameOverFlag == true) || (Outscript3.GameOverFlag == true))
        {
            audioSource.Stop();//bgm1������
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "Tumenai")
        {
            // 0.2�b��ɏ�����
            Destroy(gameObject);
            audioSource.Stop();
            //bgm1������
        }
    }
}