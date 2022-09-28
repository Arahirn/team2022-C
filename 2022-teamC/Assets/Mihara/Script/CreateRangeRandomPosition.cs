using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRangeRandomPosition : MonoBehaviour
{
    [SerializeField]
    private GameObject createPrefab;
    [SerializeField]
    private Transform rangeA;
    [SerializeField]
    private Transform rangeB;

    //���ԊԊu�̍ŏ��l
    public float minTime = 2f;
    //���ԊԊu�̍ő�l
    public float maxTime = 5f;
   
    private float interval;

    private float time = 0f;
    void Start()
    {
        //���ԊԊu�����肷��
        interval = GetRandomTime();
    }


    void Update()
    {
 
        time = time + Time.deltaTime;

        if (time > interval )
        {
            float x = -10f;
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            float z = 0f;

            Instantiate(createPrefab, new Vector3(x, y, z), createPrefab.transform.rotation);

            time = 0f;
            //���ɔ������鎞�ԊԊu�����肷��
            interval = GetRandomTime();
        }
        //�����_���Ȏ��Ԃ𐶐�����֐�
       
    }
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

}