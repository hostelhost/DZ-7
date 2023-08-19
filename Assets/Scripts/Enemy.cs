using UnityEngine;
using UnityEngine.U2D.Animation;
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteSkin))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]

public class Enemy : MonoBehaviour
{
    private AttackTrigger _attakTrigger;
    private Animator _animator;

    private void Awake()
    {
        _attakTrigger = GetComponentInChildren<AttackTrigger>();
        _animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        _attakTrigger.TriggerAttack += Attack;
    }

    private void Attack()
    {
        _animator.Play("Attack");
    }
}
