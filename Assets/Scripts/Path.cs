using UnityEngine;

public class Path : MonoBehaviour
{
    private Point[] _points;
    private System.Random _random = new System.Random();

    private void Start()
    {
        _points = GetComponentsInChildren<Point>();
    }

    public Point GiveRandomPoint => _points[_random.Next(_points.Length)];
}
