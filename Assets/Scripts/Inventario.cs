using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<GameObject> Bag = new List<GameObject>();
    public GameObject inventario;
    public bool Ativarinventario;
    public GameObject listadeItens;

    public bool Ativarcrafting;
    public GameObject crafting;
    public AudioClip pickeditem;




    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Item"))
        {
            Debug.Log("Pega Item");
            Destroy(listadeItens.transform.GetChild(0).gameObject);
            AudioSource.PlayClipAtPoint(pickeditem, transform.position);
            for (int i = 0; i < Bag.Count; i++)
            {
                if (Bag[i].GetComponent<Image>().enabled == false)
                {
                    Bag[i].GetComponent<Image>().enabled = true;
                   // Bag[i].GetComponent<Image>().sprite = coll.GetComponent<SpriteRenderer>().sprite;
                    break;
                }
            }
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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



