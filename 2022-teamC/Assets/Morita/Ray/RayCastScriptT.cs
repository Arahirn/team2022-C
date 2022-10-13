using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastScriptT : MonoBehaviour
{
    //Ray�̒���
    public float maxDistance = 50;
    public Vector2 origin;
    public float YofT;
    public RaycastHit2D hit;

    public void Update()
    {
        Vector3 ts = this.transform.position;
        origin.x = ts.x;
        origin.y = ts.y;//�n�_(�I�u�W�F�N�g�̍��W�𔽉f����)
        Vector2 direction = new Vector2(0, -1); // �x�N�g��
        Ray ray = new Ray(origin, direction); // Ray�𐶐�
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.red, 5.0f); // �����R�O�A�ԐF�łT�b�ԉ���

        hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance);

        if (hit.collider & hit.collider.gameObject.CompareTag("Tumeru"))//Tag��Tumeru�Ȃ�ray�����������I�u�W�F�N�g�̖��O��\��
        {
            Debug.Log(hit.point);
            Debug.Log(YofT);
            YofT = hit.point.y; //ray�������������W��Y���W��YofA�Ƃ������O�̕ϐ��Ő錾
        }
        else if (hit.collider & hit.collider.gameObject.CompareTag("Tumenai"))//Tag��Tumenai�Ȃ�null��\��
        {
            Debug.Log("null");
            YofT = 0f;
        }
    }
}
