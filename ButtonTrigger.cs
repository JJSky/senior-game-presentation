using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTrigger : MonoBehaviour {
    private BagController[] scripts;

    void Start()
    {
        scripts = FindObjectsOfType(typeof(BagController)) as BagController[];
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ResetButton"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if (other.CompareTag("CheckoutButton"))
        {
            foreach (BagController bag in scripts)
            {
                bag.Checkout();
            }
        }
    }
}