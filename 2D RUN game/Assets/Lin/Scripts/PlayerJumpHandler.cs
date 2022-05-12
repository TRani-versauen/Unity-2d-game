using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin;

namespace Lin
{
    public class PlayerJumpHandler : MonoBehaviour
    {
        [SerializeField]
        private PlayerView playerView = null;
        [SerializeField]
        private PlayerInputHandler inputHandler = null;

        //[HideInInspector]
        public bool IsGround = false;

        [SerializeField]
        private Transform footTransform = null;
        [SerializeField]
        private float detectFloorRange = 1f;

        [SerializeField]
        private float jumpForce = 10f;

        [SerializeField]
        private LayerMask floorLayer = default;

        private Collider2D[] collider2Ds = new Collider2D[1];

        private void Update()
        {
            IsGround = detectGround();

            if (inputHandler.IsJumpPressed && IsGround)
            {
                playerView.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            }
        }

        private bool detectGround() 
        {
            collider2Ds = new Collider2D[0];

            var collideList = Physics2D.OverlapCircleAll(footTransform.position, detectFloorRange, floorLayer);
            
            return collideList.Length > 0;
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.cyan;

            Gizmos.DrawWireSphere(footTransform.position, detectFloorRange);
        }
    }
}

