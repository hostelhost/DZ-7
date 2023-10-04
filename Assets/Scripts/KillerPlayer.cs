using UnityEngine;

public class KillerPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
            Destroy(enemy.gameObject);  
    }
}
