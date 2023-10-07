using UnityEngine;

public class SpawnerCoin : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    private Transform[] _positions;

    private void Awake()
    {
        _positions = new Transform[transform.childCount];
        Fill();
    }

    private void Start()
    {
        foreach (Transform position in _positions)
            Spawn(position);
    }

    private void Fill()
    {
        for (int i = 0; i < transform.childCount; i++)
            _positions[i] = transform.GetChild(i).transform;
    }

    private void Spawn(Transform transform)
    {
        Instantiate<Coin>(_coin, transform.position, Quaternion.identity);
    }
}
