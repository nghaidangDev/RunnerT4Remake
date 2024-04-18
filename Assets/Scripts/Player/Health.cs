using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;

    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;

    [Header("SPX")]
    [SerializeField] private AudioClip hitSound;
    [SerializeField] private AudioClip dieSound;

    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            AudioManager.instance.PlaySound(hitSound);
            anim.SetTrigger("hit");
        }
        else
        {
            if (!dead)
            {
                AudioManager.instance.PlaySound(dieSound);
                anim.SetTrigger("die");
                GetComponent<PlayerMovement>().enabled = false;
                dead = true;
            }
        }
    }
}
