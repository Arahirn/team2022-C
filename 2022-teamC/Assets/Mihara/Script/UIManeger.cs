using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManeger : MonoBehaviour
{
    [SerializeField] GameObject HowtoplayPanel;

    void Start()
    {
        BackToMenu();
    }


    public void SelectHowtoplay()
    {
        HowtoplayPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        HowtoplayPanel.SetActive(false);
    }
}
