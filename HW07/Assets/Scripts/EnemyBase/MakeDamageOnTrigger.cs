using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamageOnTrigger : MonoBehaviour
{
    public PlayerHealth PlayerHealth;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerMove>())
        {
                PlayerHealth.TakeDamage(1);
        }
    }
}
