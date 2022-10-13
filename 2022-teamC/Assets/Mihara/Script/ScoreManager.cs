using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{


    public GameObject targetObject;

    float HighScore = 0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Transform a = targetObject.transform;

        Vector3 Camerapos = a.position;
        var camy = Camerapos.y;
        if (camy > HighScore)
        {
            HighScore = camy;
        }
        this.GetComponent<Text>().text = HighScore.ToString("F2") + "m";

    }

}


