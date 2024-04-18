using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UILevel : MonoBehaviour
{
    [SerializeField] private Health playerHealth;

    [SerializeField] private Image imgLose;
    [SerializeField] private Button btnRestart;
    [SerializeField] private Button btnExit;

    private void Start()
    {

        btnRestart.onClick.AddListener(RestartGame);
        btnExit.onClick.AddListener(ExitGame);
    }

    private void Update()
    {
        LoadImgLose();
    }

    private void LoadImgLose()
    {
        if (playerHealth.GetComponent<Health>().currentHealth <= 0) 
        {
            imgLose.gameObject.SetActive(true);
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(2);
    }

    private void ExitGame()
    {
        SceneManager.LoadScene(1);
    }
}
