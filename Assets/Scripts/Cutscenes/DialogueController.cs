using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class DialogueController : MonoBehaviour
{
    public string Acampamento;
    public string Cutscene1;

    public Image bus;
    public Image kevin;
    public Image ambos;

    public GameObject buttonComeçar;

    public Text nameText;
    public TMP_Text dialogueText;

    public Animator animator;
    
    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();

        kevin.enabled = false;
        ambos.enabled = false;
    }

    public void ChangeCutscene()
    {
        SceneManager.LoadScene(Acampamento);
    }
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 3)
        {
            bus.enabled = false;
            kevin.enabled = true;
        }

        if (sentences.Count == 1)
        {
            ambos.enabled = true;
            bus.enabled = false;
            kevin.enabled = false;
        }

        if (sentences.Count == 0)
        {
            EndDialogue();
            bus.enabled = false;
            kevin.enabled = false;
            ambos.enabled = true;
            ChangeCutscene();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)// cada letra aparece aos poucos 
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }
}
