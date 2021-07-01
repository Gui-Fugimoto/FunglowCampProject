using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CraftItens : MonoBehaviour
{
    public GameObject[] crafted;
    public GameObject itenconstruido;
    public GameObject Galho;
    public GameObject Pedra;
    // Start is called before the first frame update
    void Start()
    {
        itenconstruido.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Galho == null && Pedra == null)
        {
            itenconstruido.SetActive(true);

            if (Input.GetMouseButton(0))
            {
                Destroy(itenconstruido.GetComponent<Image>());
                crafted[0].SetActive(true);
            }
        }
    }
}



