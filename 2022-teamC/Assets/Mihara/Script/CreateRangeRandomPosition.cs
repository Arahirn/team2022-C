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

    private float time;

    void Update()
    {
 
        time = time + Time.deltaTime;

        if (time > 10.0f)
        {
            float x = -10;
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            float z = 0;

            Instantiate(createPrefab, new Vector3(x, y, z), createPrefab.transform.rotation);

            time = 0f;
        }
    }
    

}