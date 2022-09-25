using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Out : MonoBehaviour
{
  
    public GameObject GameoverPanel;
   
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Block")
        {
            GameoverPanel.SetActive(true);
         
          

           
        }
    }
}
