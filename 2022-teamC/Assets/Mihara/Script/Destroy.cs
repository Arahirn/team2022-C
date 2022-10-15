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
        GameoverPanel = GameObject.Find("Panel"); //GameoverPanelっていうオブジェクトを探す
        GameObject timer = GameObject.Find("Timer"); //Timerっていうオブジェクトを探す
        TC = timer.GetComponent<TimeCounter>(); //付いているスクリプトを取得
        GameObject OS = GameObject.Find("OutStage"); //OutStageっていうオブジェクトを探す
        Outscript1 = OS.GetComponent<Out>(); //付いているスクリプトを取得
        GameObject OSL = GameObject.Find("OutStageL"); //OutStageLっていうオブジェクトを探す
        Outscript2 = OSL.GetComponent<Out>(); //付いているスクリプトを取得
        GameObject OSR = GameObject.Find("OutStageR"); //OutStageRっていうオブジェクトを探す
        Outscript3 = OSR.GetComponent<Out>();　//付いているスクリプトを取得
    }

    // Update is called once per frame
    void Update()
    {
        GameObject CRM = GameObject.Find("CreateRandomManager"); //CreateRandomManagerっていうオブジェクトを探す
        CRRP = CRM.GetComponent<CreateRangeRandomPosition>();　//付いているスクリプトを取得
        if (CRRP.createBougaiFlag == true)
        {
            audioSource.PlayOneShot(FishSound);
            //魚の音を鳴らす
        }
        if ((TC.countdownSeconds <= 0) || (Outscript1.GameOverFlag == true) || (Outscript2.GameOverFlag == true) || (Outscript3.GameOverFlag == true))
        {
            audioSource.Stop();//魚の音を消す
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突した相手にPlayerタグが付いているとき
        if (collision.gameObject.tag == "Tumenai")
        {
            // 0.2秒後に消える
            Destroy(gameObject);
            audioSource.Stop();
            //魚の音を消す
        }
    }
}