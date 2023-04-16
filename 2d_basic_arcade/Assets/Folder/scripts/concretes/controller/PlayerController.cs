using System.Collections;
using System.Collections.Generic;
using UdemyDeneme01.Combat;
using UdemyDeneme01.Movements;
using UnityEngine;


namespace UdemyDeneme01.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        bool _isLeftMouseClicked;
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        InputController _input;
        LaunchProjectile _launchProjectile;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _input = new InputController();
        }

        private void Update()
        {
            if (_input.LeftMouseClickDown)
            {
                _isLeftMouseClicked = true;

            }
            if (_input.RightMouseClickDown)
            {
                _launchProjectile.LaunchAction();
            }
        }

        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);
                _isLeftMouseClicked = false;
            }
        }

       

    }
}