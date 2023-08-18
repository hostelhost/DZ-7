using System.Collections;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

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
        float intervalBetweenSpawns = 5f;
        int maximumEnemy = 1;
        WaitForSeconds waitForSeconds = new WaitForSeconds(intervalBetweenSpawns);

        while (true)
        {
            yield return waitForSeconds;

            if (CheckMaximumNumberEnemies(maximumEnemy))
                Instantiate<Enemy>(_enemy, _transform.position, Quaternion.identity);
        }
    }

    private bool CheckMaximumNumberEnemies(int maximum)
    {
        Enemy[] enemys = FindObjectsOfType<Enemy>();
        return enemys.Length < maximum;
    }
}
