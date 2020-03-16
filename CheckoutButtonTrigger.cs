using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckoutButtonTrigger : MonoBehaviour {
    private BagController[] scripts;

    void Start()
    {
        scripts = FindObjectsOfType(typeof(BagController)) as BagController[];
    }

    void OnTriggerEnter(Collider other)
    {
        foreach (BagController bag in scripts)
        {
            bag.Checkout();
        }
    }
}
