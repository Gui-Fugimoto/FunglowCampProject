using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public int vidaMaxima;
    public int vidaAtual;

    
    public Image tresVidas;
    public Image duasVidas;
    public Image umaVida;

    public string SampleScene;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtual = vidaMaxima;
        tresVidas.enabled = true;
        duasVidas.enabled = true;
        umaVida.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LevouDano()
    {
        vidaAtual -= 1;

        if (vidaAtual == 3)
        {
            tresVidas.enabled = true;
            duasVidas.enabled = true;
            umaVida.enabled = true;
        }

        if (vidaAtual == 2)
        {
            tresVidas.enabled = false;
            duasVidas.enabled = true;
            umaVida.enabled = true;
        }

        if (vidaAtual == 1)
        {
            tresVidas.enabled = false;
            duasVidas.enabled = false;
            umaVida.enabled = true;
        }

        if (vidaAtual <= 0)
        {
            Debug.Log("perdeu");
            SceneManager.LoadScene(SampleScene);
        }
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Inimigo"))
        {
            Debug.Log("encostou");
            LevouDano();
        }
    }
}

