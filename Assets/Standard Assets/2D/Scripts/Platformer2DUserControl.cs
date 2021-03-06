using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        public BoxCollider2D sword;
        public static Platformer2DUserControl ins;
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;


        private void Start()
        {
            ins = this;
        }

        internal bool m_swordStuck
        {
            get
            {
                return sword.IsTouchingLayers(PlatformerCharacter2D.ins.m_WhatIsGround);
                
            }
        }

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButton("Jump");
            }
        }


        private void FixedUpdate()
        {
            // Read the inputs.
            bool crouch = false;
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
