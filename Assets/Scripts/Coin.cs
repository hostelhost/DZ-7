using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]

public class Coin : MonoBehaviour 
{
    private DetectorCoin _detectorCoin;

    private void Awake()
    {
        _detectorCoin = GetComponentInChildren<DetectorCoin>();
    }

    private void OnEnable()
    {
        _detectorCoin.Detected += DeleteCoin;
    }

    private void OnDisable()
    {
        _detectorCoin.Detected -= DeleteCoin;
    }

    private void DeleteCoin()
    {
        Destroy(gameObject);
    }
}
