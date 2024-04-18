using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] Button btnPlay;

    private void Start()
    {
        btnPlay.onClick.AddListener(LoadSceneMain);
    }

    private void LoadSceneMain()
    {
        SceneManager.LoadScene(1);
    }
}
