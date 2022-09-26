using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScriptA : MonoBehaviour
{
    //Ray�̒���
    public float maxDistance = 10;
    Vector2 origin;

    private void Update()
    {
        Vector3 ts = this.transform.position;
        origin.x = ts.x;
        origin.y = ts.y;//�n�_(�I�u�W�F�N�g�̍��W�𔽉f����)
        Vector2 direction = new Vector2(0, -1); // �x�N�g��
        Ray ray = new Ray(origin, direction); // Ray�𐶐�
        Debug.DrawRay(ray.origin, ray.direction * 30, Color.red, 5.0f); // �����R�O�A�ԐF�łT�b�ԉ���
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance);

            if (hit.collider)
            {
                Debug.Log(hit.collider.gameObject.name);
            }
    }
}