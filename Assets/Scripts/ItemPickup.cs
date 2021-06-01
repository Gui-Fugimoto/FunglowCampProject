using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    [SerializeField]
    public GameObject Item;
    private Image myimage;
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
         //transform.Rotate(Vector3.up * Time.deltaTime * 180);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Debug.Log("pickup item");
            Destroy(Item);

        }
    }

}
