using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
   
   
    public AudioClip[] sons;



    public GameObject[] Itens= new GameObject[5];
 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Itens[0].SetActive(false);    
                AudioSource.PlayClipAtPoint(sons[0], transform.position);// som ao pegar item
        }

        if (other.CompareTag("Player"))
        {
            Itens[1].SetActive(false);
                AudioSource.PlayClipAtPoint(sons[1], transform.position);// som ao pegar item
        }
    }


   
}
