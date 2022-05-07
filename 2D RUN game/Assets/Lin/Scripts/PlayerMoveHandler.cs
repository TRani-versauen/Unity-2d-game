using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin;

namespace Lin
{
    public class PlayerMoveHandler : MonoBehaviour
    {
        [SerializeField]
        private PlayerView playerView = null;
        [SerializeField]
        private PlayerInputHandler inputHandler = null;

        [SerializeField]
        private float walkSpeed = 5f;

        private void Update()
        {
            playerView.Velocity = new Vector2(inputHandler.HorizontalInput * walkSpeed, playerView.Velocity.y);

            if(playerView.Velocity.x > 0)
            {
                playerView.transform.localScale = new Vector2(1, 1);
            }
            else if (playerView.Velocity.x < 0)
            {
                playerView.transform.localScale = new Vector2(-1, 1);
            }
        }
    }
}
