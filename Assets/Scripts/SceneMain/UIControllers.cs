using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControllers : MonoBehaviour
{
    [SerializeField] Button btnSelectLevel;
    [SerializeField] Button btnClose;
    [SerializeField] Button btnCloseScene;

    [SerializeField] Button btnLevel1;
    [SerializeField] Image imgSelectLevel;

    private void Start()
    {
        btnSelectLevel.onClick.AddListener(SelectLevel);
        btnClose.onClick.AddListener(CloseSelectLevel);
        btnCloseScene.onClick.AddListener(CloseSceneMain);

        btnLevel1.onClick.AddListener(SelectLevel1);
    }

    private void SelectLevel()
    {
        imgSelectLevel.gameObject.SetActive(true);
    }

    private void CloseSelectLevel()
    {
        imgSelectLevel.gameObject.SetActive(false);
    }

    private void SelectLevel1()
    {
        SceneManager.LoadScene(2);
    }

    private void CloseSceneMain()
    {
        SceneManager.LoadScene(0);
    }
}