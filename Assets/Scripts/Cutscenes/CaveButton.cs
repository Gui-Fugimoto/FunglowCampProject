using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CaveButton : MonoBehaviour
{
    public Image parte1;
    public Image parte2;
    public Image parte3;

    public string InsideCave;
    public string Caverna;

    public int btnPressed = 0;
    private int btnVezesnecessarias = 2;
    // Start is called before the first frame update
    void Start()
    {
       
        parte3.enabled = false;
    }

    public void NextScene()
    {
        SceneManager.LoadScene(InsideCave);
    }
    public void NextPart()
    {
       // if (btnPressed <= btnVezesnecessarias)
        //{
       //     btnPressed += 1;
        //    parte1.enabled=false;
        //    parte2.enabled=true;
        //    Debug.Log("Uma");
        //}

        if (btnPressed < btnVezesnecessarias)
        {
            btnPressed += 1;
            parte1.enabled = false;
            parte2.enabled = false;
            parte3.enabled = true;
            Debug.Log("Dois");
        }

        if (btnPressed >= btnVezesnecessarias)
        {
            parte3.enabled = false;
            Debug.Log("Tres");
            NextScene();
        }
    }
}
