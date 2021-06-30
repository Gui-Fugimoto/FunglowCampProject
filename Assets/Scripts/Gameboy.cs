using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameboy : MonoBehaviour
{
    public GameObject gameboy;
    public GameObject lobo1;
    public GameObject lobo2;
    public GameObject lobo3;

    // Start is called before the first frame update
    void Start()
    {
        lobo1.SetActive(false);
        lobo2.SetActive(false);
        lobo3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            lobo1.SetActive(true);
            lobo2.SetActive(true);
            lobo3.SetActive(true);
            Destroy(gameboy);
        }


    }
}
