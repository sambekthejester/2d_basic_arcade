using System.Collections;
using System.Collections.Generic;
using UdemyDeneme01.Controllers;
using UnityEngine;

namespace UdemyDeneme01.abstracts.spawners
{
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(1.5f, 5f)]
        [SerializeField] float maxSpawnTime = 3f;
        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpawnTime = 3f;
        

        float _currentSpawnTime;
        float _timeBoundary;

        private void Start()
        {
            ResetTime();
        }

        private void Update()
        {
            _currentSpawnTime += Time.deltaTime;

            if (_currentSpawnTime > _timeBoundary)
            {
                Spawn();
                ResetTime();
            }
        }

        protected abstract void Spawn();
                
        
        private void ResetTime()
        {
            _currentSpawnTime = 0;
            _timeBoundary = Random.RandomRange(minSpawnTime, maxSpawnTime);
        }

    }


}

