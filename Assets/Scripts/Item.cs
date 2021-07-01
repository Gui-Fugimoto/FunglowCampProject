using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public GameObject itemGO;
    public GameObject Jogador;
    public Sprite itemSprite;
    // Start is called before the first frame update
    void Start()
    {
        Jogador = GameObject.Find("Player");
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Jogador.GetComponent<Inventario>().Itens(itemSprite);
            Destroy(itemGO);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
