using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public string Acampamento;
    public string MenuInicial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void trocaCena1()
    {
        SceneManager.LoadScene(Acampamento);
    }

    public void trocaCenaMenu()
    {
        SceneManager.LoadScene(MenuInicial);
    }

    public void Sair()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
