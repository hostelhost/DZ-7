using System;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    public event Action TriggerAttack;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
            TriggerAttack?.Invoke();
    }
}
