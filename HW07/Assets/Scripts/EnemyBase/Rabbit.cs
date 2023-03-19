using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    public float AttakPeriod = 7f;
    public Animator Animator;

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if(_timer > AttakPeriod)
        {
            _timer= 0;
            Animator.SetTrigger("Attack");
        }
    }
}
