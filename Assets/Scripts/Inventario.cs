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
   
    public int counter;
    public bool Ativarcrafting;
    public GameObject crafting;
    public AudioClip pickeditem;
    public Sprite Teste;

    void Start()
    {
        counter = 0;
        
    }

    public void Itens(Sprite objeto)
    {
        Debug.Log(objeto);
        Bag[counter].GetComponent<Image>().sprite = objeto;
        counter++;
        
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



