using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIControllers : MonoBehaviour
{
    [SerializeField] private Button btnSelectLevel;
    [SerializeField] private Button btnClose;
    [SerializeField] private Button btnCloseScene;

    [SerializeField] private Button btnLevel1;
    [SerializeField] private Button btnLevel2;
    [SerializeField] private Image imgSelectLevel;

    [Header("Star")]
    [SerializeField] private TMP_Text starText;


    private void Start()
    {
        btnSelectLevel.onClick.AddListener(SelectLevel);
        btnClose.onClick.AddListener(CloseSelectLevel);
        btnCloseScene.onClick.AddListener(CloseSceneMain);

        btnLevel1.onClick.AddListener(SelectLevel1);
        btnLevel2.onClick.AddListener(SelectLevel2);

        //Star
        int totalStar = PlayerPrefs.GetInt("TotalStar", 0);
        starText.text = totalStar.ToString();
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
        AudioManager.instance.PlayMusic("Theme");
        SceneManager.LoadScene(2);
    }

    private void SelectLevel2()
    {
        AudioManager.instance.PlayMusic("Theme");
        SceneManager.LoadScene(3);
    }

    private void CloseSceneMain()
    {
        SceneManager.LoadScene(0);
    }
}
