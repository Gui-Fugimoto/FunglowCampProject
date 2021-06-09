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
    // Start is called before the first frame update
    void Start()
    {
      Canvas.GetComponent<Image>();
      Canvas.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
           
            myimage.enabled = true;
            botaodropar.interactable = true;
            
        }
    }
}
