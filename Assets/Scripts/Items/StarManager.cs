using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    public static StarManager instance;

    [SerializeField] private TMP_Text starText;
    private int star = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void AddStar(int amount)
    {
        star += amount;
        UpdateStarUI();
    }

    void UpdateStarUI()
    {
        starText.text = star.ToString();
    }

    public void UpdateStar()
    {
        int totalStar = PlayerPrefs.GetInt("TotalStar", 0);

        totalStar += star;

        PlayerPrefs.SetInt("TotalStar", totalStar);
    }
}
