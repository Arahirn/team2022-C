using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxHeightScoreUI : MonoBehaviour
{
    public RayCastScriptA rcsa;
    public RayCastScriptB rcsb;
    public RayCastScriptC rcsc;
    public RayCastScriptD rcsd;
    public RayCastScriptE rcse;
    public RayCastScriptF rcsf;
    public RayCastScriptG rcsg;
    public float max;
    string MAX;
    Text text;
    float HighScore;

    // Start is called before the first frame update
    void Start()
    {
        HighScore = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ra = GameObject.Find("Ray A"); //Ray Aっていうオブジェクトを探す
        rcsa = ra.GetComponent<RayCastScriptA>();　//付いているスクリプトを取得
        GameObject rb = GameObject.Find("Ray B");
        rcsb = rb.GetComponent<RayCastScriptB>();
        GameObject rc = GameObject.Find("Ray C");
        rcsc = rc.GetComponent<RayCastScriptC>();
        GameObject rd = GameObject.Find("Ray D");
        rcsd = rd.GetComponent<RayCastScriptD>();
        GameObject re = GameObject.Find("Ray E");
        rcse = re.GetComponent<RayCastScriptE>();
        GameObject rf = GameObject.Find("Ray F");
        rcsf = rf.GetComponent<RayCastScriptF>();
        GameObject rg = GameObject.Find("Ray G");
        rcsg = rg.GetComponent<RayCastScriptG>();
        text = GameObject.Find("Score").GetComponent<Text>();
        max = Mathf.Max(rcsa.YofA, rcsb.YofB, rcsc.YofC, rcsd.YofD, rcse.YofE, rcsf.YofF, rcsg.YofG);
        if (max > HighScore)
        {
            HighScore = max;
        }
        MAX = HighScore.ToString();
        this.text.text = MAX;
    }
}