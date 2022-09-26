using System.Collections;
using UnityEngine;

public class ObjectDragTransform : MonoBehaviour
{
    bool rayFlag = true;
    bool pushFlag = false;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = 50f;
    }
    //�I�u�W�F�N�g���N���b�N���ăh���b�O��Ԃɂ���ԌĂяo�����֐��iUnity�̃}�E�X�C�x���g�j
    void OnMouseDrag()
    {
        //�}�E�X�J�[�\���y�уI�u�W�F�N�g�̃X�N���[�����W���擾
        Vector3 objectScreenPoint =
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);

        //�X�N���[�����W�����[���h���W�ɕϊ�
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

        //��]���~�߂�
        rb.angularVelocity = 0;

        if (rayFlag == true)//tag��Tumeru����Tumenai�ɕύX
        {
            rayFlag = false;
            this.tag = "Tumenai";
        }

        //W���͂�+90�x��]
        if (Input.GetKey(KeyCode.W))
        {
            if (pushFlag == false)  // �������ςȂ��ł͂Ȃ��Ƃ�
            {
                pushFlag = true;    // ������Ԃɂ���
                transform.Rotate(new Vector3(0, 0, 90));
                // ��������i�e��łA�I�u�W�F�N�g���o��������Ȃǂ̃C�x���g�j
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
    void OnMouseUp()
    {
        rb.velocity = Vector3.zero;
        if (rayFlag == false)//Tag��Tumeru�ɖ߂�
        {
            rayFlag = true;
            this.tag = "Tumeru";
            rb.mass = 50f;
        }
    }
}