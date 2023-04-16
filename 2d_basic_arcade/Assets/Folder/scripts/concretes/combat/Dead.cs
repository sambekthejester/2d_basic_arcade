using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 namespace UdemyDeneme01.Combat
{


    public class Dead : MonoBehaviour
    {
        private bool _isDead;
        public bool IsDead => _isDead;
        public event System.Action OnDead;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            _isDead = true;
            OnDead?.Invoke();
            Time.timeScale = 0f;
        }




    }


}