using System.Collections.Generic;
using UnityEngine;

public class ArrowManeger : MonoBehaviour
{
    [SerializeField] private CoinManeger _coinManager;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private Rigidbody _playerRigidbody;

    private Coin _closestCoin;
    private Transform _target;

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
        UpdateArrowTransform();
    }

    private void UpdateArrowTransform()
    {
        _closestCoin = _coinManager.GetClosest(transform.position);

        _target = _closestCoin.transform;

        Vector3 targetPosition = _target.position;

        Vector3 toTarget = targetPosition - transform.position;

        Vector3 toTargetXZ = new Vector3(toTarget.x, 0f, toTarget.z);

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(toTargetXZ), Time.deltaTime * 5f);

        transform.position = _playerTransform.position;
    }
}
