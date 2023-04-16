using System.Collections;
using System.Collections.Generic;
using UdemyDeneme01.Enums;
using UnityEngine;

namespace UdemyDeneme01.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 5f;
        Rigidbody2D _rigidbody2D;
        [SerializeField] DirectionEnum direction;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();

        }
        private void Start()
        {
            _rigidbody2D.velocity = SelectedDirection() * moveSpeed;
        }
        private Vector2 SelectedDirection()
        {
            Vector2 selectedDirection;
            if (direction ==DirectionEnum.Left)
            {
                selectedDirection = Vector2.left;
            }
            else
            {
                selectedDirection = Vector2.right;
            }
            return selectedDirection;
        }

    }

}
