using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}
