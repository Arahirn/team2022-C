using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // �Փ˂��������Player�^�O���t���Ă���Ƃ�
        if (collision.gameObject.tag == "Tumenai")
        {
            // 0.2�b��ɏ�����
            Destroy(gameObject);
        }
    }
}