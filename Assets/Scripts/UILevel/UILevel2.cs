using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UILevel2 : MonoBehaviour
{
    [SerializeField] private Health playerHealth;
    [SerializeField] private GameObject player;


    [SerializeField] private Image imgLose;
    [SerializeField] private Image imgPause;

    [SerializeField] private Button btnRestartLv2;
    [SerializeField] private Button btnExit;
    [SerializeField] private Button btnPauseStart;
    [SerializeField] private Button btnPauseExit;
    [SerializeField] private Button btnPause;
    [SerializeField] private Button btnExitWin;

    [Header("Button Audio")]
    [SerializeField] private Button btnAudio;
    [SerializeField] private Button btnExitAudio;
    [SerializeField] private Image imgAudio;

    private void Start()
    {
        btnPauseExit.onClick.AddListener(ExitGame);
        btnPauseStart.onClick.AddListener(ExitImgPause);
        btnPause.onClick.AddListener(LoadImgPause);

        btnRestartLv2.onClick.AddListener(RestartGame);
        btnExit.onClick.AddListener(ExitGame);

        btnExitWin.onClick.AddListener(ExitGame);

        btnAudio.onClick.AddListener(LoadImgAudio);
        btnExitAudio.onClick.AddListener(ExitImgAudio);

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
        AudioManager.instance.PlayMusic("Theme");
        SceneManager.LoadScene(3);
    }

    private void ExitGame()
    {
        AudioManager.instance.mucsicSource.Stop();
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

    private void LoadImgAudio()
    {
        player.gameObject.SetActive(false);
        imgAudio.gameObject.SetActive(true);
    }

    private void ExitImgAudio()
    {
        imgAudio.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
    }
}
