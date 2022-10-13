using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public RayCastScriptA rcsa;
    public RayCastScriptB rcsb;
    public RayCastScriptC rcsc;
    public RayCastScriptD rcsd;
    public RayCastScriptE rcse;
    public RayCastScriptF rcsf;
    public RayCastScriptG rcsg;
    public RayCastScriptH rcsh;
    public RayCastScriptI rcsi;
    public RayCastScriptJ rcsj;
    public RayCastScriptK rcsk;
    public RayCastScriptL rcsl;
    public RayCastScriptM rcsm;
    public RayCastScriptN rcsn;
    public RayCastScriptO rcso;
    public RayCastScriptP rcsp;
    public RayCastScriptQ rcsq;
    public RayCastScriptR rcsr;
    public RayCastScriptS rcss;
    public RayCastScriptT rcst;
    public RayCastScriptU rcsu;
    public RayCastScriptV rcsv;
    public RayCastScriptW rcsw;
    public RayCastScriptX rcsx;
    public RayCastScriptY rcsy;
    public RayCastScriptZ rcsz;
    public RayCastScriptAA rcsaa;
    public RayCastScriptAB rcsab;
    public RayCastScriptAC rcsac;

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
        GameObject rh = GameObject.Find("Ray H");
        rcsh = rh.GetComponent<RayCastScriptH>();
        GameObject ri = GameObject.Find("Ray I");
        rcsi = ri.GetComponent<RayCastScriptI>();
        GameObject rj = GameObject.Find("Ray J");
        rcsj = rj.GetComponent<RayCastScriptJ>();
        GameObject rk = GameObject.Find("Ray K");
        rcsk = rk.GetComponent<RayCastScriptK>();
        GameObject rl = GameObject.Find("Ray L");
        rcsl = rl.GetComponent<RayCastScriptL>();
        GameObject rm = GameObject.Find("Ray M");
        rcsm = rm.GetComponent<RayCastScriptM>();
        GameObject rn = GameObject.Find("Ray N");
        rcsn = rn.GetComponent<RayCastScriptN>();
        GameObject ro = GameObject.Find("Ray O");
        rcso = ro.GetComponent<RayCastScriptO>();
        GameObject rp = GameObject.Find("Ray P");
        rcsp = rp.GetComponent<RayCastScriptP>();
        GameObject rq = GameObject.Find("Ray Q");
        rcsq = rq.GetComponent<RayCastScriptQ>();
        GameObject rr = GameObject.Find("Ray R");
        rcsr = rr.GetComponent<RayCastScriptR>();
        GameObject rs = GameObject.Find("Ray S");
        rcss = rs.GetComponent<RayCastScriptS>();
        GameObject rt = GameObject.Find("Ray T");
        rcst = rt.GetComponent<RayCastScriptT>();
        GameObject ru = GameObject.Find("Ray U");
        rcsu = ru.GetComponent<RayCastScriptU>();
        GameObject rv = GameObject.Find("Ray V");
        rcsv = rv.GetComponent<RayCastScriptV>();
        GameObject rw = GameObject.Find("Ray W");
        rcsw = rw.GetComponent<RayCastScriptW>();
        GameObject rx = GameObject.Find("Ray X");
        rcsx = rx.GetComponent<RayCastScriptX>();
        GameObject ry = GameObject.Find("Ray Y");
        rcsy = ry.GetComponent<RayCastScriptY>();
        GameObject rz = GameObject.Find("Ray Z");
        rcsz = rz.GetComponent<RayCastScriptZ>();
        GameObject raa = GameObject.Find("Ray AA");
        rcsaa = raa.GetComponent<RayCastScriptAA>();
        GameObject rab = GameObject.Find("Ray AB");
        rcsab = rab.GetComponent<RayCastScriptAB>();
        GameObject rac = GameObject.Find("Ray AC");
        rcsac = rac.GetComponent<RayCastScriptAC>();

        text = GameObject.Find("ScoreR").GetComponent<Text>();

        max = Mathf.Max(rcsa.YofA, rcsb.YofB, rcsc.YofC, rcsd.YofD, rcse.YofE, rcsf.YofF, rcsg.YofG, rcsh.YofH, rcsi.YofI, rcsj.YofJ, rcsk.YofK, rcsl.YofL, rcsm.YofM, rcsn.YofN, rcso.YofO, rcsp.YofP, rcsq.YofQ, rcsr.YofR, rcss.YofS, rcst.YofT, rcsu.YofU, rcsv.YofV, rcsw.YofW, rcsx.YofX, rcsy.YofY, rcsz.YofZ, rcsaa.YofAA, rcsab.YofAB, rcsac.YofAC);
        if (max > HighScore)
        {
            HighScore = max;
        }
        MAX = HighScore.ToString("N2");
        this.text.text = MAX;
    }
}