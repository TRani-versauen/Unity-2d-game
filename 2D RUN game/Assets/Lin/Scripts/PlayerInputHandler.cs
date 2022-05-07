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

        private void Update()
        {
            HorizontalInput = Input.GetAxis("Horizontal");
            IsJumpPressed = Input.GetKeyDown(KeyCode.Space);
        }
    }
}

