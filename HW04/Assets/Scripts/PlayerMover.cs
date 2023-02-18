using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Transform _ñameraCenter;
    [SerializeField] private float TorqueVelue;

    private Rigidbody _rigitbody;

    private void Start()
    {
        _rigitbody = GetComponent<Rigidbody>();
        _rigitbody.maxAngularVelocity = 500;
    }

    private void FixedUpdate()
    {
        _rigitbody.AddTorque(_ñameraCenter.right * Input.GetAxis("Vertical") * TorqueVelue);
        _rigitbody.AddTorque(-_ñameraCenter.forward * Input.GetAxis("Horizontal") * TorqueVelue);
    }
}
