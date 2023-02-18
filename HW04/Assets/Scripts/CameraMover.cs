using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody _playerRigidbody;
    [SerializeField] private float _speedRotationCamera = 10f; 

    private List<Vector3> VelocitiesList = new List<Vector3>();

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            VelocitiesList.Add(Vector3.zero);
        }
    }

    private void FixedUpdate()
    {
        VelocitiesList.Add(_playerRigidbody.velocity);
        VelocitiesList.RemoveAt(0);
    }

    private void Update()
    {
        UpdateCameraPosition();
    }

    private void UpdateCameraPosition()
    {
        Vector3 summ = Vector3.zero;

        for (int i = 0; i < VelocitiesList.Count; i++)
        {
            summ += VelocitiesList[i];
        }

        transform.position = _playerTransform.position;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(summ), Time.deltaTime * _speedRotationCamera);
    }
}
