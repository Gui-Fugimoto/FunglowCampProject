using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveExit : MonoBehaviour
{
    public string Floresta;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void trocaPraFloresta()
    {
        SceneManager.LoadScene(Floresta);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            trocaPraFloresta();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
