using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderCena : MonoBehaviour
{
    public string Cova;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void trocaPraCaverna()
    {
        SceneManager.LoadScene(Cova);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            trocaPraCaverna();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}