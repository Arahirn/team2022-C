using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopManager : MonoBehaviour
{
    private string GTag = "Spawn";
    
    Rigidbody2D rb;
  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.CompareTag(GTag))
        {

            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
          
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.None;
            
        }
    }
}
