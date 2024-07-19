using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private readonly string HORIZONTAL = "Horizontal";
    private readonly string VERTICAL = "Vertical";

    [SerializeField] private float _speed;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        Vector2 moveVector = Vector2.right * Input.GetAxis(HORIZONTAL) + Vector2.up * Input.GetAxis(VERTICAL);
        _rb.MovePosition(_rb.position + moveVector * _speed * Time.deltaTime);
    }
}
