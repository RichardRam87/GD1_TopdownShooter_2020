﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyObj;
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _spawnThreshold = 2;

    private float _timer;

    private void Start()
    {
        SpawnEnemy();
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer >= _spawnThreshold)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);
        SpawnPoint spawnpoint = _spawnPoints[randomIndex];
        Vector3 spawnPosition = spawnpoint.GetSpawnPosition();        

        Instantiate(_enemyObj, spawnPosition, spawnpoint.transform.rotation);
        _timer = 0;
    }
}
