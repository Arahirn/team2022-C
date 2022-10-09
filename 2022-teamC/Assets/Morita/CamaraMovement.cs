using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovement : MonoBehaviour
{
    public RayCastScriptA rcsa;
    public RayCastScriptB rcsb;
    public RayCastScriptC rcsc;
    public RayCastScriptD rcsd;
    public RayCastScriptE rcse;
    public RayCastScriptF rcsf;
    public RayCastScriptG rcsg;
    double Yaverage;
    public double YAVE;
    float YAVETWO;
    Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        tf = this.GetComponent<Transform>();
    }

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
        Yaverage = (rcsa.YofA + rcsb.YofB + rcsc.YofC + rcsd.YofD + rcse.YofE + rcsf.YofF + rcsg.YofG) / 7.0;
        YAVE = Yaverage + 3.5;
        YAVETWO = (float)YAVE;
        this.tf.position = new Vector3(0, YAVETWO, -15);
    }
}