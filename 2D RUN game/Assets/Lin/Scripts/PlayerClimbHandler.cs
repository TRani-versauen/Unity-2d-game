using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin;

namespace Lin
{
    public class PlayerClimbHandler : MonoBehaviour
    {
        [SerializeField]
        private PlayerView playerView = null;

        [SerializeField]
        private PlayerJumpHandler jumpHandler = null;

        [SerializeField]
        private Transform detectWallTransform = null;

        [SerializeField]
        private float detectWallDistance = 1.5f;

        [SerializeField]
        private LayerMask wallLayer = default;

        public bool IsClimbing = false;

        private void Update()
        {
            if (Physics2D.Raycast(detectWallTransform.position, Vector2.right * playerView.transform.localScale.x, detectWallDistance, wallLayer) && !jumpHandler.IsGround)
            {
                IsClimbing = true;
            }
            else
            {
                IsClimbing = false;
            }

            playerView.SetBool("isClimb", IsClimbing);

            if (!IsClimbing)
            {
                playerView.SetGravity(true);
            }
            else
            {
                playerView.SetGravity(false);
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(detectWallTransform.position, detectWallTransform.position + Vector3.right * detectWallDistance * playerView.transform.localScale.x);
        }
    }

}
