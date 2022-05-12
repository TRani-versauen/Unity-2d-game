using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin;

namespace Lin
{
    public class PlayerCrounchHandler : MonoBehaviour
    {
        [SerializeField]
        private PlayerView playerView = null;

        [SerializeField]
        private PlayerInputHandler inputHandler = null;

        private void Update()
        {
            playerView.SetBool("isCrounch", inputHandler.IsCrounchPressing);

            if (inputHandler.IsCrounchPressing)
                playerView.SetHalfHeight();
            else
                playerView.SetFullHeight();
        }
    }

}
