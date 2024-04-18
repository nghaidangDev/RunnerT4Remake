using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UILevel : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private GameObject player;


    [SerializeField] private Image imgLose;
    [SerializeField] private Image imgPause;

    [SerializeField] private Button btnRestart;
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnPauseStart;
    [SerializeField] private Button btnPauseExit;
    [SerializeField] private Button btnPause;
    [SerializeField] private Button btnExitWin;

    private void Start()
    {
        btnPauseExit.onClick.AddListener(ExitGame);
        btnPauseStart.onClick.AddListener(ExitImgPause);
        btnPause.onClick.AddListener(LoadImgPause);

        btnRestart.onClick.AddListener(RestartGame);
        btnExit.onClick.AddListener(ExitGame);

        btnExitWin.onClick.AddListener(ExitGame);
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

    private void LoadImgPause()
    {
        player.gameObject.SetActive(false);
        imgPause.gameObject.SetActive(true);
    }

    private void ExitImgPause()
    {
        imgPause.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
    }
}
