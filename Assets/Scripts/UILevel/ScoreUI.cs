
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public int score;
    public static ScoreUI Instance;
    [SerializeField] private TMP_Text scoreTxt;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        scoreTxt.text = score.ToString();
    }

}
