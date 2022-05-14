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

        Vector2 startColliderSize = Vector2.zero;

        private void Start()
        {
            startColliderSize = playerCollider.size;
        }

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

        public void SetGravity(bool value)
        {
            playerRigidbody.velocity = value ? new Vector2(playerRigidbody.velocity.x, playerRigidbody.velocity.y) : new Vector2(playerRigidbody.velocity.x, 0);
            playerRigidbody.gravityScale = value ? 2.5f : 0f;
        }

        public void SetFullHeight()
        {
            playerCollider.size = new Vector2(startColliderSize.x, startColliderSize.y);
        }

        public void SetHalfHeight()
        {
            playerCollider.size = new Vector2(startColliderSize.x, startColliderSize.y / 2);
        }

        public void SetBool(string boolName, bool isOn)
        {
            playerAnimator.SetBool(boolName, isOn);
        }

        public void SetTrigger(string triggerName) 
        {
            playerAnimator.SetTrigger(triggerName);
        }

    }
}

