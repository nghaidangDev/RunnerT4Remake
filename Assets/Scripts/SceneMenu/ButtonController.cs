using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] Button btnPlay;

    [Header("Trick")]
    [SerializeField] Image imgTrick;
    [SerializeField] Button btnTrick;
    [SerializeField] Button btnExitTrick;

    private void Start()
    {
        btnPlay.onClick.AddListener(LoadSceneMain);
        btnTrick.onClick.AddListener(ButtonTrick);
        btnExitTrick.onClick.AddListener(ExitButtonTrick);
    }

    private void LoadSceneMain()
    {
        SceneManager.LoadScene(1);
    }

    private void ButtonTrick()
    {
        imgTrick.gameObject.SetActive(true);
    }

    private void ExitButtonTrick()
    {
        imgTrick.gameObject.SetActive(false);
    }
}
