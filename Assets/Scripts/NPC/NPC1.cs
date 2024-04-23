using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NPC1 : MonoBehaviour
{
    private PlayerMovement playerMovement;
    [SerializeField] GameObject dialoguaPanel;
    [SerializeField] TMP_Text dialogueText;
    [SerializeField] string[] dialogue;
    private int index;

    [SerializeField] private float wordSpeed;
    public bool playerIsClose;

    private void Awake()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose) 
        {
            if (dialoguaPanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguaPanel.SetActive(true);
            }
        }
    }

    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguaPanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        if (index < dialogue.Length - 1) 
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            playerMovement.enabled = true;
            zeroText();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerMovement.enabled = false;
            playerMovement.AnimationIdle();
            playerIsClose = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerIsClose = false;
            playerMovement.AnimationRun();
            zeroText();
            Destroy(gameObject);
        }
    }
}
