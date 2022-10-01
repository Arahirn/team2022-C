using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectDragTransform : MonoBehaviour
{
    bool rayFlag = true;
    bool pushFlag = false;
    Rigidbody2D rb;
    int DragCount = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = 50f;
    }

    void OnMouseDrag() //オブジェクトをクリックしてドラッグ状態にある間呼び出される関数（Unityのマウスイベント）
    {
        if (DragCount < 1) 
        {
            //マウスカーソル及びオブジェクトのスクリーン座標を取得
            Vector3 objectScreenPoint =
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

            //スクリーン座標をワールド座標に変換
            Vector3 objectWorldPoint = Camera.main.ScreenToWorldPoint(objectScreenPoint);

            // rigidbody2d
            rb.velocity = Vector2.zero;
            Vector2 vec = objectWorldPoint - transform.position;
            float length = vec.magnitude;
            rb.mass = 1f;

            if (length > 0.5f)
            {
                float power = 300f;
                rb.AddForce(vec * power);
            }
            else
            {
                rb.velocity = Vector2.zero;
            }

            //回転を止める
            rb.angularVelocity = 0;

            if (rayFlag == true)//tagをTumeruからTumenaiに変更
            {
                rayFlag = false;
                this.tag = "Tumenai";
            }

            //W入力で+90度回転
            if (Input.GetKey(KeyCode.W))
            {
                if (pushFlag == false)  // 押しっぱなしではないとき
                {
                    pushFlag = true;    // 押し状態にする
                    transform.Rotate(new Vector3(0, 0, 90));
                    // 何かする（弾を打つ、オブジェクトを出現させるなどのイベント）
                }
            }
            else
            {
                pushFlag = false;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(new Vector3(0, 0, 1));
            }
        }
    }

    void OnMouseUp()
    {
        rb.velocity = Vector3.zero;
        if (rayFlag == false)//TagをTumeruに戻す
        {
            rayFlag = true;
            this.tag = "Tumeru";
            rb.mass = 50f; //オブジェクトの質量を設定
            DragCount = DragCount+1;
        }
    }
}