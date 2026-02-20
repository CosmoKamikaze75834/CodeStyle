using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;
    private Transform _target;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var direction = (_target.position - transform.position).normalized;

        _rigidbody.transform.up = direction;
        _rigidbody.velocity = direction * _speed;
    }

    public void AssignTarget(Transform target)
    {
        _target = target;
    }
}