using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMovement : MonoBehaviour
{
    public RayCastScriptA rcsa;
    public RayCastScriptB rcsb;
    public RayCastScriptC rcsc;
    public RayCastScriptD rcsd;
    double Yaverage;
    public double YAVE;
    Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        tf = this.GetComponent<Transform>();
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
        Yaverage = (rcsa.YofA + rcsb.YofB + rcsc.YofC + rcsd.YofD) / 4.0;
        YAVE = Yaverage + 3.5;
        float YAVETWO = (float)YAVE;
        this.tf.position = new Vector3(0, YAVETWO, -15);

    }
}
