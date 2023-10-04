using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class KillerEnemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
            Destroy(player.gameObject);
    }
}