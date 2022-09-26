using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracheck : MonoBehaviour
{
    private Camera _mainCamera;

    void Start()
    {
        // �J�����I�u�W�F�N�g���擾
        GameObject obj = GameObject.Find("Main Camera");
        _mainCamera = obj.GetComponent<Camera>();

        // ���W�l���o��
        Debug.Log(getScreenTopLeft().x + ", " + getScreenTopLeft().y);
        Debug.Log(getScreenBottomRight().x + ", " + getScreenBottomRight().y);
    }

    private Vector3 getScreenTopLeft()
    {
        // ��ʂ̍�����擾
        Vector3 topLeft = _mainCamera.ScreenToWorldPoint(Vector3.zero);
        // �㉺���]
        topLeft.Scale(new Vector3(1f, -1f, 1f));
        return topLeft;
    }

    private Vector3 getScreenBottomRight()
    {
        // ��ʂ̉E�����擾
        Vector3 bottomRight = _mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f));
        // �㉺���]
        bottomRight.Scale(new Vector3(1f, -1f, 1f));
        return bottomRight;
    }
}
