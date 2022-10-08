using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class Subject : MonoBehaviour
{
    private Vector3 _moveDirection;
    private float _maxRayDistance;

    [SerializeField] private float speed;

    protected virtual void Awake()
    {
        Vector2 randomVector = Random.insideUnitCircle.normalized;
        _moveDirection = new Vector3(randomVector.x, 0, randomVector.y);
    }

    private void Update()
    {
        transform.position += _moveDirection * (speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _moveDirection = Vector3.Reflect(_moveDirection, collision.GetContact(0).normal);
        OnFaced();
    }

    protected abstract void OnFaced();
}
