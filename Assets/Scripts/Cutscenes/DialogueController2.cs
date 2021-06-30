using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class DialogueController2 : MonoBehaviour
{
    public string Acampamento;
    public string Cutscene2;

    public Image imageStory2;
    public GameObject buttonComeçar;

    public GameObject buttonComeçar2;

    public Text nameText;
    public TMP_Text dialogueText2;

    public Animator animator;

    private Queue<string> sentences;
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void ChangeToAcampamento()
    {
        SceneManager.LoadScene(Acampamento);
    }
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence2();
    }

    public void DisplayNextSentence2()
    {
        if (sentences.Count == 0)
        {
            EndDialogue2();
            imageStory2.enabled = false;
            ChangeToAcampamento();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)// cada letra aparece aos poucos 
    {
        dialogueText2.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText2.text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    void EndDialogue2()
    {
        animator.SetBool("IsOpen", false);

        buttonComeçar.SetActive(false);// cutscene 1
    }
}


