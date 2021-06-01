using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioUI : MonoBehaviour
{
    [SerializeField]
    public Image myimage;
    public Button botaodropar;
    public GameObject Item;
    public GameObject RemoveButton;
    private GameObject Canvas;
    //public bool[] isFull;
    //public GameObject[] InventarioSlot;
    // Start is called before the first frame update
    void Start()
    {
      Canvas.GetComponent<Image>();
      Canvas.GetComponent<Button>();
        myimage.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myimage.enabled == true)
        {
            botaodropar.interactable = true;
            
        }
    }

   // void OnTriggerExit(Collider other)
    //{
      //  if (other.CompareTag("Player"))
      //  {
     //       myimage.enabled = true;
      //      botaodropar.interactable = true;
      //  }
    //}
}
