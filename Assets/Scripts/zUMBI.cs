using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class zUMBI : MonoBehaviour
{
    public Text textTalk;
    public Image chatBox;
    public bool canInteract = false;
    public GameObject spriteCostas;
    public GameObject spriteFrente;
    public GameObject playerChar;
    public string Ending;
    // Start is called before the first frame update
    void Start()
    {
        spriteFrente.SetActive(false);
        chatBox.enabled = false;
        textTalk.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("e") && (canInteract == true))
        {
            if ((chatBox.enabled == false))
            {
                chatBox.enabled = true;
                textTalk.enabled = true;
                playerChar.GetComponent<PlayerController>().enabled = false;
                spriteFrente.SetActive(true);
                spriteCostas.SetActive(false);
                StartCoroutine(ToBeContinue());
            }

            else
            {
                chatBox.enabled = false;
                textTalk.enabled = false;
                playerChar.GetComponent<PlayerController>().enabled = true;
                
            }
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
    IEnumerator ToBeContinue()
    {
        yield return new WaitForSeconds(5f);
        trocaPraEnding();

    }
    public void trocaPraEnding()
    {
        SceneManager.LoadScene(Ending);
    }
}
