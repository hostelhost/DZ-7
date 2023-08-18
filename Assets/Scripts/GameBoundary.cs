using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]

public class GameBoundary : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
