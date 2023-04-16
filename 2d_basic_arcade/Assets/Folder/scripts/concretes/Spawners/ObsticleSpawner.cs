using System.Collections;
using System.Collections.Generic;
using UdemyDeneme01.abstracts.spawners;
using UdemyDeneme01.Controllers;
using UnityEngine;

namespace UdemyDeneme01.Spawners
{
    public class ObsticleSpawner : BaseSpawner
    {
        [SerializeField] EnemyController[] enemies;

        protected override void Spawn()
        {
            int enemyIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[enemyIndex], this.transform);

        }
        

    }


}
