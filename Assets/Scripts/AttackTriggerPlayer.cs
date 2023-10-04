using UnityEngine;

public class AttackTriggerPlayer : MonoBehaviour
{
    private Animator _animator;
    private bool _isAttack;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        AttackButtonPress();
    }

    private void FixedUpdate()
    {
        Attack();
    }

    private void AttackButtonPress()
    {
        if (Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.Mouse0))
            _isAttack = true;
    }

    private void Attack()
    {
        if (_isAttack)
        {
            _animator.SetTrigger("IsAttack");
            _isAttack = !_isAttack;
        }
    }
}
