using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                // Read the jump input in Update so button presses aren't missed.
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
			}
			if (Input.GetButton ("Submit")) {
				Time.timeScale = 1;
				Application.LoadLevel(Application.loadedLevel);
			}
		}
		
		double cooldown = 1;

        private void FixedUpdate()
        {
            // Read the inputs.
            bool fire = Input.GetButton("Fire1");
			if (fire && cooldown > 0) {
				cooldown -= 1;
				GetComponent<Animator>().Play ("FireStraightAnimation");
				m_Character.Shoot();
			}
			cooldown += cooldown >= 1 ? 0 : 0.04;
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            // Pass all parameters to the character control script.
            m_Character.Move(h, false, m_Jump);
            m_Jump = false;
        }
    }
}
