using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vidas : MonoBehaviour
{
    public int vidaMaxima;
    public int vidaAtual;

    public Image imageMaçacura;


    public Image tresVidas;
    public Image duasVidas;
    public Image umaVida;
    public bool isInvincible;

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

        if (Input.GetKeyDown(KeyCode.Q) && imageMaçacura.enabled == true)
        {
            imageMaçacura.enabled = false;
            vidaAtual = vidaMaxima;

            //+ meia vida ou 1 vida no HUD
        }
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

    public void GanhouVida()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hitbox") && (isInvincible == false))
        {
            Debug.Log("encostou");
            LevouDano();
            GameObject child = gameObject.transform.Find("Sound Dano").gameObject;
            child.GetComponent<AudioSource>().Play();
            StartCoroutine(InvincibilityFrames());
        }
    }
    IEnumerator InvincibilityFrames()
    {
        isInvincible = true;
        yield return new WaitForSeconds(2f);
        isInvincible = false;
    }
}

