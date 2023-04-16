using System.Collections;
using System.Collections.Generic;
using UdemyDeneme01.Combat;
using UnityEngine;

namespace UdemyDeneme01.Uis
{

    public class GameCanvas : MonoBehaviour
    {
        GameObject gameOverPanel;       
        private void Awake()
        {
            gameOverPanel = transform.GetChild(1).gameObject;
           
        }
        private void Start()
        {
            Dead dead = FindObjectOfType<Dead>();
            dead.OnDead += HandleOnDead;
        }

        private void HandleOnDead()
        {
            gameOverPanel.SetActive(true);
        }
    }

}
