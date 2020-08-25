﻿using UnityEngine;

namespace PlayerAttributes
{
    public class PlayerCollider : MonoBehaviour
    {
        [SerializeField]
        private PlayerMovement movement;        

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.tag == "Wall")
            {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}