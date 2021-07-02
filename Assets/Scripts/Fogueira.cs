using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fogueira : MonoBehaviour
{
    public Image galhoImage;
    public Image folhasImage;
    public GameObject joshFeliz;
    public GameObject joshTriste;
    public ParticleSystem Fogo;
    public bool canInteract = false;
    // Start is called before the first frame update
    void Start()
    {
        joshTriste.SetActive(false);
        //Fogo.GetComponent<ParticleSystem>().enableEmission = false;
        galhoImage.enabled = false;
        folhasImage.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp("e") && (galhoImage.enabled == true) && (folhasImage.enabled == true) && (canInteract == true))
        {
            joshFeliz.SetActive(false);
            galhoImage.enabled = false;
            folhasImage.enabled = false;
            joshTriste.SetActive(true);
            ParticleSystem dota = Instantiate(Fogo, gameObject.transform.position + gameObject.transform.up * 1, gameObject.transform.rotation * Quaternion.Euler(-90f, 0f, 0f));
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            canInteract = true;
            Debug.Log("vai maninho fala com ele");
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            canInteract = false;
            Debug.Log("nao fale!");
        }
    }
}
