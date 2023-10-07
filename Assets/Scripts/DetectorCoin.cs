using System;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]

public class DetectorCoin : MonoBehaviour 
{
    public event Action Detected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player> (out Player player))
            Detected?.Invoke();
    }
}
