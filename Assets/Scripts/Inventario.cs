using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<GameObject> Bag = new List<GameObject>();
    //public List<Sprite> itens = new List<Sprite>();

    public GameObject inventario;
    public bool Ativarinventario;
    public GameObject listadeItens;

    public bool Ativarcrafting;
    public GameObject crafting;
    public AudioClip pickeditem;

    void Start()
    {
        var sprite = Resources.Load<Sprite>("Itens/Galho/pedra/maçacura");
    }


    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Item"))
        {
            Destroy(listadeItens.transform.GetChild(0).gameObject);
            Debug.Log("Pega Item");
            AudioSource.PlayClipAtPoint(pickeditem, transform.position);
            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].GetComponent<Image>().enabled == false)
                {
                   
                    Bag[i].GetComponent<Image>().enabled = true;
                    break;
                }
            }
        }
    }
    void Update()
    {
        if (Ativarinventario)
        {
            inventario.SetActive(true);
        }
        else
        {
            inventario.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            Ativarinventario = !Ativarinventario;
        }

        if (Ativarcrafting)
        {
            crafting.SetActive(true);
        }
        else
        {
            crafting.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Ativarcrafting = !Ativarcrafting;
        }
    }
}



