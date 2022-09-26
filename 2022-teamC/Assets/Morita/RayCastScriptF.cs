using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScriptF : MonoBehaviour
{
    //Ray�̒���
    public float maxDistance = 10;
    Vector2 origin;
    public float YofF;
    public RaycastHit2D hit;

    private void Update()
    {
        Vector3 ts = this.transform.position;
        origin.x = ts.x;
        origin.y = ts.y;//�n�_(�I�u�W�F�N�g�̍��W�𔽉f����)
        Vector2 direction = new Vector2(0, -1); // �x�N�g��
        Ray ray = new Ray(origin, direction); // Ray�𐶐�
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.red, 5.0f); // �����R�O�A�ԐF�łT�b�ԉ���
        hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance);

        if (hit.collider & hit.collider.gameObject.CompareTag("Tumeru"))
        {
            Debug.Log(YofF);
            YofF = hit.point.y;
        }
        else if (hit.collider & hit.collider.gameObject.CompareTag("Tumenai"))
        {
            Debug.Log("null");
        }
    }
}