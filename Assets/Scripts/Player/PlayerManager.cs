using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject deadZone;
    [SerializeField] private GameObject winZone;
    [SerializeField] private GameObject player;
    [SerializeField] private Image imgLose;
    [SerializeField] private Image imgWin;

    public int scoreStar { get; private set; }

    private void Update()
    {
        MoveDeadZone();
    }

    public void MoveDeadZone()
    {
        deadZone.transform.position = new Vector2(transform.position.x, deadZone.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DeadZone")
        {
            AudioManager.instance.mucsicSource.Stop();
            AudioManager.instance.PlaySFX("Lose");
            player.gameObject.SetActive(false);
            imgLose.gameObject.SetActive(true);

        }else if (collision.tag == "ZoneWin")
        {
            AudioManager.instance.mucsicSource.Stop();
            AudioManager.instance.PlaySFX("Win");
            player.gameObject.SetActive(false);
            imgWin.gameObject.SetActive(true);
        }else if (collision.tag == "Star")
        {
            collision.gameObject.SetActive(false);
            scoreStar++;
        }
    }
}
