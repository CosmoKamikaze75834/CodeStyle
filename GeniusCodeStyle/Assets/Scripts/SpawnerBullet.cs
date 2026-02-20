using System.Collections;
using UnityEngine;

public class SpawnerBullet : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _timeWaitShooting = 2;
    [SerializeField] private Transform _target;

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    private IEnumerator SpawnObject()
    {
        bool isWork = true;

        while (isWork)
        {
            var bullet = Instantiate(_bullet, transform.position, Quaternion.identity);
            bullet.AssignTarget(_target);

            yield return new WaitForSeconds(_timeWaitShooting);
        }
    }
}