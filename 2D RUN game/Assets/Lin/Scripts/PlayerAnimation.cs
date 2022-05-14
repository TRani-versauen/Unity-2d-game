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
        private PlayerMoveHandler moveHandler = null;

        [SerializeField]
        private PlayerJumpHandler jumpHandler = null;

        private void Update()
        {
            playerView.SetBool("isJump", !jumpHandler.IsGround);
        }
    }

}
