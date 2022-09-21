using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScriptA : MonoBehaviour
{
    //Rayの長さ
    public float maxDistance = 10;
    Vector2 origin;

    private void Update()
    {
        Vector3 ts = this.transform.position;
        origin.x = ts.x;
        origin.y = ts.y;//始点(オブジェクトの座標を反映する)
        Vector2 direction = new Vector2(0, -1); // ベクトル
        Ray ray = new Ray(origin, direction); // Rayを生成
        Debug.DrawRay(ray.origin, ray.direction * 30, Color.red, 5.0f); // 長さ３０、赤色で５秒間可視化
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance);

            if (hit.collider)
            {
                Debug.Log(hit.collider.gameObject.name);
            }
    }
}