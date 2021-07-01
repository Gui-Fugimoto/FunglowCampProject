using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderCena : MonoBehaviour
{
    public string CavernaCutscene;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void trocaPraCaverna()
    {
        SceneManager.LoadScene(CavernaCutscene);
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