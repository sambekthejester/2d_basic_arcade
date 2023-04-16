using System.Collections;
using System.Collections.Generic;
using UdemyDeneme01.abstracts.controllers;
using UnityEngine;

namespace UdemyDeneme01.Controllers
{
    public class ProjectileController : LifeCycleController
    {
        private void OnTriggerEnter2D(Collider2D collision)
                  
        
        {
            EnemyController enemy = collision.GetComponent<EnemyController>();
            if (enemy!=null)
            {
                GameManager.Instance.IncreaseScore();
                Destroy(enemy.gameObject);
                Destroy(this.gameObject);
            }
            
        }

    }
}

