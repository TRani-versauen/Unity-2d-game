using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin;

namespace Lin
{
    public class PlayerInputHandler : MonoBehaviour
    {
        public float HorizontalInput = 0f;
        public bool IsJumpPressed = false;
        public bool IsSlidePressing = false;
        public bool IsCrounchPressing = false;

        private void Update()
        {
            HorizontalInput = Input.GetAxis("Horizontal");
            IsJumpPressed = Input.GetKeyDown(KeyCode.Space);
            IsSlidePressing = Input.GetKey(KeyCode.LeftShift);
            IsCrounchPressing = Input.GetKey(KeyCode.LeftControl);
        }
    }
}

