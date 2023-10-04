using System.Collections;
using UnityEngine;

public class SpawnerPlayer : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Transform _transform;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Start()
    {
        StartCoroutine(StartCreating());
    }

    private IEnumerator StartCreating()
    {
        float intervalBetweenSpawns = 10f;
        int maximumPlayer = 1;
        WaitForSeconds waitForSeconds = new WaitForSeconds(intervalBetweenSpawns);

        while (true)
        {
            yield return waitForSeconds;

            if (CheckMaximumPlayers(maximumPlayer))
                Instantiate<Player>(_player, transform.position, Quaternion.identity);
        }
    }

    private bool CheckMaximumPlayers(int maximum)
    {
        Player[] player = FindObjectsOfType<Player>();
        return player.Length < maximum;
    }
}
