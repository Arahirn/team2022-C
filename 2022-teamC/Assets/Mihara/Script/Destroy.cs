using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
    public AudioClip FishSound;
    private AudioSource audioSource;
    public CreateRangeRandomPosition CRRP;
    public GameObject GameoverPanel;
    public TimeCounter TC;
    public Out Outscript1;
    public Out Outscript2;
    public Out Outscript3;

    // Use this for initialization
    void Start()
    {
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
        GameObject CRM = GameObject.Find("CreateRandomManager"); //CreateRandomManager���Ă����I�u�W�F�N�g��T��
        CRRP = CRM.GetComponent<CreateRangeRandomPosition>();�@//�t���Ă���X�N���v�g���擾
        if (CRRP.createBougaiFlag == true)
        {
            audioSource.PlayOneShot(FishSound);
            //���̉���炷
        }
        if ((TC.countdownSeconds <= 0) || (Outscript1.GameOverFlag == true) || (Outscript2.GameOverFlag == true) || (Outscript3.GameOverFlag == true))
        {
            audioSource.Stop();//���̉�������
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
            //���̉�������
        }
    }
}