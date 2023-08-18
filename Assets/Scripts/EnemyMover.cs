using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed = 3.0f;

    private Path _path;
    private Point _target;
    private Vector3 _localScale;
    private float _standartLocalScaleX;

    private void Awake()
    {
        _path = FindObjectOfType<Path>();
    }

    private void Start()
    { 
        TakeNewPoint();
        _localScale = transform.localScale;
        _standartLocalScaleX = _localScale.x;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);

        if (transform.position.x >= _target.transform.position.x)
            _localScale.x = -_standartLocalScaleX;
        else
            _localScale.x = _standartLocalScaleX;

        transform.localScale = _localScale;

        if (transform.position.x == _target.transform.position.x)
            TakeNewPoint();
    }

    private void TakeNewPoint()
    {
        if (_target != null)
            _target.Reached -= TakeNewPoint;

        _target = _path.GiveRandomPoint;
        _target.Reached += TakeNewPoint;
    }
}
