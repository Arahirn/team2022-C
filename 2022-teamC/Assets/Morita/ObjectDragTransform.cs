using System.Collections;
using UnityEngine;

public class ObjectDragTransform : MonoBehaviour
{

    Rigidbody2D rb;
    float Vector3;
    Vector3 angularVelocity;

    //オブジェクトをクリックしてドラッグ状態にある間呼び出される関数（Unityのマウスイベント）
    void OnMouseDrag()
    {
        //マウスカーソル及びオブジェクトのスクリーン座標を取得
        Vector3 objectScreenPoint =
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

        //スクリーン座標をワールド座標に変換
        Vector3 objectWorldPoint = Camera.main.ScreenToWorldPoint(objectScreenPoint);

        //オブジェクトの座標を変更する
        transform.position = objectWorldPoint;

        //回転を止める
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = 0;

    }   
}