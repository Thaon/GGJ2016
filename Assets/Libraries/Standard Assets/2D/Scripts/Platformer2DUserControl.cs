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

        public bool m_isActive = true;
        GameObject m_changeAreaTrigger;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (Input.GetButtonDown("Use"))
            {
                //Debug.Log(m_changeAreaTrigger);
                if (m_changeAreaTrigger != null)
                {
                    m_changeAreaTrigger.GetComponent<ChangeArea>().Use();
                    m_changeAreaTrigger = null;
                }
            }
        }


        private void FixedUpdate()
        {
            if (m_isActive)
            {
                // Read the inputs.
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
                // Pass all parameters to the character control script.
                m_Character.Move(h, false, m_Jump);
                m_Jump = false;
            }
            else
            {
                m_Character.Move(0, false, false);
            }
        }

        void GiveControl()
        {
            m_isActive = true;
        }

        void TakeControl()
        {
            m_isActive = false;
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "AreaTrigger")
            {
                m_changeAreaTrigger = other.gameObject;
            }
        }
        void OnTriggerExit2D(Collider2D other)
        {
            if (other.tag == "AreaTrigger")
            {
                m_changeAreaTrigger = null;
            }
        }
    }
}
