using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCena1 : MonoBehaviour
{
    public GameObject item;
    public Image itemImage;
    // Start is called before the first frame update
    void Start()
    {
        itemImage.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            itemImage.enabled = true;
            Destroy(item, 0.2f);
        }
    }
}
