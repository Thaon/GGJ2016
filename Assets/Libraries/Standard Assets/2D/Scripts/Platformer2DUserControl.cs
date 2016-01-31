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
        GameObject m_InteractTrigger;
        GameObject m_keyPiece;


        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (Input.GetButtonDown("Use"))
            {
                Debug.Log(m_changeAreaTrigger);
                Debug.Log(m_InteractTrigger);


                if (m_changeAreaTrigger != null)
                {
                    m_changeAreaTrigger.GetComponent<ChangeArea>().Use();
                    m_changeAreaTrigger = null;
                }

                if (m_InteractTrigger != null)
                {
                    m_InteractTrigger.GetComponent<Interact>().Use();
                    m_InteractTrigger = null;
                }

                if (m_keyPiece != null)
                {
                    m_keyPiece.GetComponent<KeyPiece>().Use();
                    m_keyPiece = null;
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

            if (other.tag == "Interactible")
            {
                m_InteractTrigger = other.gameObject;
            }

            if (other.tag == "KeyPiece")
            {
                m_keyPiece = other.gameObject;
            }
        }
        void OnTriggerExit2D(Collider2D other)
        {
            if (other.tag == "AreaTrigger")
            {
                m_changeAreaTrigger = null;
            }

            if (other.tag == "Interactible")
            {
                m_InteractTrigger = null;
            }

            if (other.tag == "KeyPiece")
            {
                m_keyPiece = null;
            }
        }
        public void ResetPosition()
        {
            transform.position = GameObject.Find("New_pos_Start").transform.position;
        }
    }
}
