using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocarCena : MonoBehaviour
{
    public string SampleScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void trocaCena1()
    {
        SceneManager.LoadScene(SampleScene);
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
