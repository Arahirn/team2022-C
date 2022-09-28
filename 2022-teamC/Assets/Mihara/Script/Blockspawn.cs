using UnityEngine;
using System.Collections;

public class Blockspawn : MonoBehaviour
{
    GameObject[] tagObjects;
    public GameObject[] Blocks;
    private int number;
    bool isCalledOnce = false;

    void Update()
    {
        int count1 = GameObject.FindGameObjectsWithTag("Tumenai").Length;
        int count2 = GameObject.FindGameObjectsWithTag("Spawn").Length;


        if ((count1+count2 == 0) && (!isCalledOnce))
        {
            isCalledOnce = true;
            StartCoroutine("SpawnManager");
        }
    }
    private IEnumerator SpawnManager()
    {
        // 4•b‘Ò‚Â
        yield return new WaitForSeconds(4.0f);
        number = Random.Range(0, Blocks.Length);
        Instantiate(Blocks[number], transform.position, transform.rotation);
        isCalledOnce = false;
    }
}