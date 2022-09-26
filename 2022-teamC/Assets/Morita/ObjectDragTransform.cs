using System.Collections;
using UnityEngine;

public class ObjectDragTransform : MonoBehaviour
{

    Rigidbody2D rb;
    float Vector3;
    Vector3 angularVelocity;

    //�I�u�W�F�N�g���N���b�N���ăh���b�O��Ԃɂ���ԌĂяo�����֐��iUnity�̃}�E�X�C�x���g�j
    void OnMouseDrag()
    {
        //�}�E�X�J�[�\���y�уI�u�W�F�N�g�̃X�N���[�����W���擾
        Vector3 objectScreenPoint =
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

        //�X�N���[�����W�����[���h���W�ɕϊ�
        Vector3 objectWorldPoint = Camera.main.ScreenToWorldPoint(objectScreenPoint);

        //�I�u�W�F�N�g�̍��W��ύX����
        transform.position = objectWorldPoint;

        //��]���~�߂�
        rb = GetComponent<Rigidbody2D>();
        rb.angularVelocity = 0;

    }   
}