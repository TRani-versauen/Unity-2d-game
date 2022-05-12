using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin;

namespace Lin
{
    public class PlayerSlideHandler : MonoBehaviour
    {
        [SerializeField]
        private PlayerView playerView = null;

        [SerializeField]
        private PlayerInputHandler inputHandler = null;

        private void Update()
        {
            playerView.SetBool("isSlide", inputHandler.IsSlidePressing);

            if (inputHandler.IsSlidePressing)
                playerView.SetHalfHeight();
            else
                playerView.SetFullHeight();
        }

    }

}
