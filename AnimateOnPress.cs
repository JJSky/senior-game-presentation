using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    [RequireComponent(typeof(Interactable))]
    public class AnimateOnPress : MonoBehaviour
    {
        private Animator m_Animator;
        private bool isPressed;

        void Start()
        {
            m_Animator = gameObject.GetComponent<Animator>();
            isPressed = false;
        }

        void Update()
        {
            if (isPressed == false)
            {
                m_Animator.SetBool("isPressed", false);
            }

            if (isPressed == true)
            {
                m_Animator.SetBool("isPressed", true);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "hand")
            {
                isPressed = true;
                Debug.Log("entered");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "hand")
            {
                isPressed = false;
                Debug.Log("exit");
            }
        }
    }
}

