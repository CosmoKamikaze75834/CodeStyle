using UnityEngine;

public class PointMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _arrayPlaces;

    private int _currentPoint;

    private void Update()
    {
        var index = _arrayPlaces[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, index.position, _speed * Time.deltaTime);

        if (transform.position == index.position) 
            MoveNextPoint();
    }

    private void MoveNextPoint()
    {
        _currentPoint++;

        if (_currentPoint == _arrayPlaces.Length)
            _currentPoint = 0;

        var positionCurrentPoint = _arrayPlaces[_currentPoint].transform.position;

        transform.forward = positionCurrentPoint - transform.position;
    }
}