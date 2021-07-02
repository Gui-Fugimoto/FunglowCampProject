using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoshTriste : MonoBehaviour
{
    public Image chatBox;
    public Text textTalk;
    public bool canInteract = false;
    public GameObject playerChar;
    public GameObject gameBoy;
    public Text loiroTextOld;
    public Text loiroTextNew;
    public Text asiaticoTextOld;
    public Text asiaticoTextNew;
    // Start is called before the first frame update
    void Start()
    {
        textTalk.enabled = false;
        chatBox.enabled = false;
        loiroTextNew.enabled = false;
        asiaticoTextNew.enabled = false;
        gameBoy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("e") && (canInteract == true))
        {
            if ((chatBox.enabled == false))
            {
                chatBox.enabled = true;
                Debug.Log("Aparece");
                playerChar.GetComponent<PlayerController>().enabled = false;
                textTalk.enabled = true;
                loiroTextOld.text = loiroTextNew.text;
                asiaticoTextOld.text = asiaticoTextNew.text;
                gameBoy.SetActive(true);

            }

            else
            {
                chatBox.enabled = false;
                Debug.Log("Desaparece");
                playerChar.GetComponent<PlayerController>().enabled = true;
                textTalk.enabled = false;
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
}
