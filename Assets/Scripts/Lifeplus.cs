using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifeplus : MonoBehaviour
{
    public Image imageMaçacura;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            imageMaçacura.enabled = false;
            //+ meia vida ou 1 vida no HUD
        }
    }
}
