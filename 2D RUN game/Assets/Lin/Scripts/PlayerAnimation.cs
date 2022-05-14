using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin;

namespace Lin
{
    public class PlayerAnimation : MonoBehaviour
    {
        [SerializeField]
        private PlayerView playerView = null;

        [SerializeField]
        private PlayerInputHandler inputHandler = null;

        [SerializeField]
        private PlayerMoveHandler moveHandler = null;

        [SerializeField]
        private PlayerJumpHandler jumpHandler = null;

        private void Update()
        {
            playerView.SetBool("isJump", !jumpHandler.IsGround);

            if(Mathf.Abs(inputHandler.HorizontalInput) > .1f)
            {
                playerView.SetBool("isRun", true);
            }
            else
            {
                playerView.SetBool("isRun", false);
            }
        }
    }

}
