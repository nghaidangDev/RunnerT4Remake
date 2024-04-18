using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap1 : MonoBehaviour
{
    [SerializeField] private float damageTrap1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damageTrap1);
        }
    }
}
