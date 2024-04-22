using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    private PlayerManager playerManager;
    [SerializeField] private TMP_Text scoreTxt;

    private void Awake()
    {
        playerManager = FindObjectOfType<PlayerManager>();
    }

    private void Update()
    {
        scoreTxt.text = playerManager.scoreStar.ToString();
    }
}
