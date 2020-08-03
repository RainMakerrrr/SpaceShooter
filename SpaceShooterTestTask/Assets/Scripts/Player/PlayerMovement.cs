using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private PlayerData _playerData;
    private Rigidbody2D _rigidbody;
    private Joystick _joystick;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _joystick = FindObjectOfType<Joystick>();
    }
   
    private void FixedUpdate()
    {
        float verticalInput = Input.GetAxis("Vertical") * _moveSpeed;
        float horizontalInput = Input.GetAxis("Horizontal") *_moveSpeed;

        _rigidbody.velocity = new Vector3(horizontalInput, verticalInput, 0f);

        // for mobile joystick input
        //_rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _joystick.Vertical * _moveSpeed, 0f);

        _playerData.Position = transform.position;
        LimitBounds();
    }

    private void LimitBounds()
    {
        if (transform.position.x <= -8.2f) transform.position = new Vector3(-8.2f, transform.position.y, transform.position.z);
        if (transform.position.x >= 8.2f) transform.position = new Vector3(8.2f, transform.position.y, transform.position.z);

        if (transform.position.y <= -4f) transform.position = new Vector3(transform.position.x, -4f, transform.position.z);
        if (transform.position.y >= 4f) transform.position = new Vector3(transform.position.x, 4f, transform.position.z);

    }
}
