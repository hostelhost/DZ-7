using UnityEngine;
using UnityEngine.U2D.Animation;
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(SpriteSkin))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(EnemyMover))]

public class Enemy : MonoBehaviour
{
    private AttackTriggerEnemy _attakTrigger;
    private Animator _animator;

    private void Awake()
    {
        _attakTrigger = GetComponentInChildren<AttackTriggerEnemy>();
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
