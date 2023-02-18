using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Transform _�ameraCenter;
    [SerializeField] private float TorqueVelue;

    private Rigidbody _rigitbody;

    private void Start()
    {
        _rigitbody = GetComponent<Rigidbody>();
        _rigitbody.maxAngularVelocity = 500;
    }

    private void FixedUpdate()
    {
        _rigitbody.AddTorque(_�ameraCenter.right * Input.GetAxis("Vertical") * TorqueVelue);
        _rigitbody.AddTorque(-_�ameraCenter.forward * Input.GetAxis("Horizontal") * TorqueVelue);
    }
}
