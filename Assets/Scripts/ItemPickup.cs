using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemPickup : MonoBehaviour
{
    
    public GameObject Item;
    //private Image myimage;
    private InventarioUI inventario;
    public GameObject ItemBotao;
    void Start()
    {
        //inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<InventarioUI>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 180);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           Debug.Log("pegou item");
           Destroy(Item);
            
        }
    }

}
