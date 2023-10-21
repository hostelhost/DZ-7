using System.Collections;
using System.Transactions;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private float _intervalBetweenSpawns = 5f;
    private int _maximumEnemy = 2;

    private void Start()
    {
        StartCoroutine(StartCreating());
    }

    private void Update()
    {
        if (IsEnoughEnemies() == false)
        {
            StartCoroutine(StartCreating());
        }
    }

    private IEnumerator StartCreating()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_intervalBetweenSpawns);

        while (IsEnoughEnemies() == false)
        {
            Instantiate<Enemy>(_enemy, transform.position, Quaternion.identity);

            yield return waitForSeconds;
        }

        StopCoroutine(StartCreating());
    }

    private bool IsEnoughEnemies()
    {
        Enemy[] enemys = FindObjectsOfType<Enemy>();
        return enemys.Length == _maximumEnemy;
    }
}
