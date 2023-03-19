using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamageOnTrigger : MonoBehaviour
{
    public EnemyHealth EnemyHealth;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Bullet>())
        {
                EnemyHealth.TakeDamage(1);
        }
    }
}
