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

    [Header("SPX")]
    [SerializeField] private AudioClip deadSound;
    [SerializeField] private AudioClip winSound;

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
            AudioManager.instance.PlaySound(deadSound);
            player.gameObject.SetActive(false);
            imgLose.gameObject.SetActive(true);

        }else if (collision.tag == "ZoneWin")
        {
            AudioManager.instance.PlaySound(winSound);
            player.gameObject.SetActive(false);
            imgWin.gameObject.SetActive(true);
        }
    }
}
