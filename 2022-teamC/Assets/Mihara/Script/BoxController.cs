using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{

    void OnBecameInvisible()
    {
        GameObject.Destroy(this.gameObject);
    }

    void Update()
    {
        transform.position += new Vector3(3, 0, 0) * Time.deltaTime;
    }
}
