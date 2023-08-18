using System;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]

public class Point : MonoBehaviour
{
    public event Action Reached;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy))
            Reached?.Invoke();
    }
}
