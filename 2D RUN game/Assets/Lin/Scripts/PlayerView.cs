using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin;

namespace Lin
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D playerRigidbody = null;
        [SerializeField]
        private CapsuleCollider2D playerCollider = null;
        [SerializeField]
        private Animator playerAnimator = null;

        public Vector2 Velocity
        {
            get => playerRigidbody.velocity;
            set
            {
                playerRigidbody.velocity = value;
            }
        }

        public void AddForce(Vector2 force, ForceMode2D forceMode)
        {
            playerRigidbody.AddForce(force, forceMode);
        }
    }
}

