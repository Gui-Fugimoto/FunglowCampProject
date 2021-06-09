using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioUI : MonoBehaviour
{
    [SerializeField]
    public AudioClip estilingue;
    public GameObject[] itemarmazenado = new GameObject[5];
    public GameObject[] btnsdroppar= new GameObject[5];
    public GameObject[] Itens = new GameObject[5];
    public GameObject Inventario;
    void Start()
    {

        Inventario.SetActive(false);

        itemarmazenado[0].SetActive(false);
        itemarmazenado[1].SetActive(false);

        btnsdroppar[0].SetActive(false);
        btnsdroppar[1].SetActive(false);
    }

    void Update()
    {

        if (Input.GetKeyUp(KeyCode.M))// ativa o inventario antes de pegar o item
        {
            Inventario.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.M))// desativa o inventario antes de pegar o item
        {
            Inventario.SetActive(true);
        }

        if (Itens[0].activeSelf==false)// se já pegou o galho ativar no inventario
        {
            Inventario.SetActive(true);

            itemarmazenado[0].SetActive(true);

            btnsdroppar[0].SetActive(true);

         
        }

        if (Itens[1].activeSelf == false)// se já pegou a pedra ativar no inventario
        {
            Inventario.SetActive(true);

            itemarmazenado[1].SetActive(true);

            btnsdroppar[1].SetActive(true);

        }
    }

    public void OnPointerDown()
    {
        if (itemarmazenado[0].activeSelf == true && itemarmazenado[1].activeSelf==false)// aperta btndropar do galho e dropa
        {
            itemarmazenado[0].SetActive(false);


            btnsdroppar[0].SetActive(false);

            Itens[0].SetActive(true);

        }
        if (itemarmazenado[0].activeSelf == false && itemarmazenado[1].activeSelf==true)// aperta btndropar da pedra e dropa
        {
            itemarmazenado[1].SetActive(false);


            btnsdroppar[1].SetActive(false);

            Itens[1].SetActive(true);

        }
       
    }

    public void Craft()
    {
        if(itemarmazenado[0].activeSelf==true && itemarmazenado[1].activeSelf == true)// se tiver os dois items anteriores clica no panel do terceiro slot e cria o item
        {
            itemarmazenado[2].SetActive(true);
            btnsdroppar[2].SetActive(true);
            AudioSource.PlayClipAtPoint(estilingue, transform.position);

           // Destroy(itemarmazenado[0]);
          //  Destroy(btnsdroppar[0]);

           // Destroy(itemarmazenado[1]);
          //  Destroy(btnsdroppar[1]);
        }
    }
}
