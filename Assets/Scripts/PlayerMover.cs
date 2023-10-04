using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    private Rigidbody2D _player;
    private Animator _animator;
    private Vector2 _moveVector;
    private float _speed = 5f;
    private float _jumpForce = 5f;
    private bool _isJumping = false;
    private bool _isFaceRight = true;

    private void Awake()
    {
        _player = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        ButtonPressReader();
    }

    private void FixedUpdate()
    {
        Run();
        Jump();
    }

    private void Run()
    {
        Reflect();
        _animator.SetFloat("MoveX", Mathf.Abs(_moveVector.x));
        _player.velocity = new Vector2(_moveVector.x * _speed, _player.velocity.y);
    }

    private void ButtonPressReader()
    {
        _moveVector.x = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
            _isJumping = !_isJumping;
    }

    private void Jump()
    {
        if (_isJumping)
        {
            _animator.SetTrigger("Jump");
            _player.velocity = new Vector2(_player.velocity.x, _jumpForce);
            _isJumping = !_isJumping;
        }
    }

    private void Reflect()
    {
        if ((_moveVector.x > 0 && _isFaceRight == false) || (_moveVector.x < 0 && _isFaceRight == true))
        {
            transform.localScale *= new Vector2(-1, 1);
            _isFaceRight = !_isFaceRight;
        }
    }
}
