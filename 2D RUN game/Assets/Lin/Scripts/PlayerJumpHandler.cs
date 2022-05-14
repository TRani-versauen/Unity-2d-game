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
        [SerializeField]
        private PlayerClimbHandler climbHandler = null;

        //[HideInInspector]
        public bool IsGround = false;

        public bool IsKickWallJump = false;

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

            if (IsGround)
                ResetIsKickWallJump();

            if (inputHandler.IsJumpPressed)
            {
                if (IsGround)
                {
                    playerView.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                }
                if (climbHandler.IsClimbing)
                {
                    playerView.transform.localScale = new Vector3(-playerView.transform.localScale.x , playerView.transform.localScale.y, playerView.transform.localScale.z);
                    playerView.AddForce(new Vector2(playerView.transform.localScale.x * 3, jumpForce), ForceMode2D.Impulse);
                    IsKickWallJump = true;
                    Invoke(nameof(ResetIsKickWallJump), .25f);
                }
            }
        }

        private bool detectGround() 
        {
            collider2Ds = new Collider2D[0];

            var collideList = Physics2D.OverlapCircleAll(footTransform.position, detectFloorRange, floorLayer);
            
            return collideList.Length > 0;
        }

        private void ResetIsKickWallJump()
        {
            IsKickWallJump = false;
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.cyan;

            Gizmos.DrawWireSphere(footTransform.position, detectFloorRange);
        }
    }
}

