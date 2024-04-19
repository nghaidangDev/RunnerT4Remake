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
    [SerializeField] Button btnLevel2;
    [SerializeField] Image imgSelectLevel;

    private void Start()
    {
        btnSelectLevel.onClick.AddListener(SelectLevel);
        btnClose.onClick.AddListener(CloseSelectLevel);
        btnCloseScene.onClick.AddListener(CloseSceneMain);

        btnLevel1.onClick.AddListener(SelectLevel1);
        btnLevel2.onClick.AddListener(SelectLevel2);
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
        AudioManager.instance.mucsicSource.Play();
        SceneManager.LoadScene(2);
    }

    private void SelectLevel2()
    {
        SceneManager.LoadScene(3);
    }

    private void CloseSceneMain()
    {
        SceneManager.LoadScene(0);
    }
}
