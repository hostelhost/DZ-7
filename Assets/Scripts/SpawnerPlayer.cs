using UnityEngine;

public class SpawnerPlayer : MonoBehaviour
{
    [SerializeField] private Player _player;

    private int _maximumPlayersOnStage = 1;

    private void Update()
    {
        if (CheckMaximumPlayers())
            Instantiate<Player>(_player, transform.position, Quaternion.identity);
    }

    private bool CheckMaximumPlayers()
    {
        Player[] player = FindObjectsOfType<Player>();
        return player.Length < _maximumPlayersOnStage;
    }
}
