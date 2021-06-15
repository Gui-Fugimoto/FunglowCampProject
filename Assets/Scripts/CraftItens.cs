﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CraftItens : MonoBehaviour
{
    public GameObject[] crafted;
    public Image[] itenconstruido;
    public Image[] necessários;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (necessários[0].enabled == true && necessários[1].enabled == true)
        {
            itenconstruido[0].enabled = true;
        }

        if (Input.GetMouseButton(0))
        {
            itenconstruido[0].enabled = false;
            necessários[0].enabled = false;
            necessários[1].enabled = false;
            crafted[0].SetActive(true);
        }
    }

   
}


