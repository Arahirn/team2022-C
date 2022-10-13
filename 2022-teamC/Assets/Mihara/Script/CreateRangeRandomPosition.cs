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

    //ŠÔŠÔŠu‚ÌÅ¬’l
    public float minTime = 2f;
    //ŠÔŠÔŠu‚ÌÅ‘å’l
    public float maxTime = 5f;

    private float interval;

    private float time = 0f;
    void Start()
    {
        //ŠÔŠÔŠu‚ğŒˆ’è‚·‚é
        interval = GetRandomTime();
    }


    void Update()
    {

        time = time + Time.deltaTime;

        if (time > interval)
        {
            float x = -10f;
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            float z = 0f;

            Instantiate(createPrefab, new Vector3(x, y, z), createPrefab.transform.rotation);

            time = 0f;
            //Ÿ‚É”­¶‚·‚éŠÔŠÔŠu‚ğŒˆ’è‚·‚é
            interval = GetRandomTime();
        }
        //ƒ‰ƒ“ƒ_ƒ€‚ÈŠÔ‚ğ¶¬‚·‚éŠÖ”

    }
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }


}