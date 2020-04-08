using System;
using Sirenix.OdinInspector;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : ObjectPool
{
    [GUIColor(0.2f,0.5f,1f)]
    [SerializeField] private GameObject _enemyPrefab;
    [GUIColor(0.9f,1f,0.6f)]
    [InfoBox("Spawns")]
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0;

    private void Start()
    {
        Initialize(_enemyPrefab);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _elapsedTime = 0;

                int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
                
                SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
            }
        }
    }

    [Button]
    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        Debug.Log("a");

        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}
