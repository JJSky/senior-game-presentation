using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
    [RequireComponent(typeof(Interactable))]
    public class FadeOnHover : MonoBehaviour
    {
        private Animator m_Animator;
        private bool hovering;

        void Start()
        {
            m_Animator = gameObject.GetComponent<Animator>();
            hovering = false;
        }

        void Update()
        {
            if (hovering == false)
            {
                m_Animator.SetBool("hovering", false);
            }

            if (hovering == true)
            {
                m_Animator.SetBool("hovering", true);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "hand")
            {
                hovering = true;
                Debug.Log("entered");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "hand")
            {
                hovering = false;
                Debug.Log("exit");
            }
        }
    }
}

