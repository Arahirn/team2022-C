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
        if ((TC.countdownSeconds <= 0) || (Outscript1.GameOverFlag == true) || (Outscript2.GameOverFlag == true) || (Outscript3.GameOverFlag == true))
        {
            audioSource.Stop();//bgm1を消す
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
            //bgm1を消す
        }
    }
}