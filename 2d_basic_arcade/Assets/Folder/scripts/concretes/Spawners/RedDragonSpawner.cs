using System.Collections;
using System.Collections.Generic;
using UdemyDeneme01.abstracts.spawners;
using UdemyDeneme01.Controllers;
using UnityEngine;

namespace UdemyDeneme01.Spawners
{
    public class RedDragonSpawner : BaseSpawner

    {
        [SerializeField] EnemyController enemy;
        protected override void Spawn()
        {
            Instantiate(enemy, this.transform);
        }
    }


}

