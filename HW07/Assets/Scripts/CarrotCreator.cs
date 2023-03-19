using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotCreator : MonoBehaviour
{
    public GameObject CarrotPrefab;
    public Transform Spawn;

    public void Creat()
    {
        Instantiate(CarrotPrefab,Spawn.position,Quaternion.identity);
    }
}
