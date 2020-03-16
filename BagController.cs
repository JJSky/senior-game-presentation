using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagController : MonoBehaviour {

    private List<GameObject> heldItems = new List<GameObject>();
    private GameObject ScoreSign;

    void Awake()
    {
        ScoreSign = GameObject.Find("ScoreSign").gameObject;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9 && !heldItems.Contains(other.gameObject))
        {
            // Add to held items
            heldItems.Add(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9 && heldItems.Contains(other.gameObject))
        {
            // Remove from held items
            heldItems.Remove(other.gameObject);
        }
    }

    public void Checkout()
    {
        print("do checkout stuff");
        float score = 0;

        foreach (GameObject item in heldItems)
        {
            score += item.gameObject.GetComponent<ItemController>().scoreSuccess;
            Destroy(item.gameObject);
        }
        heldItems.Clear();
        print(score);
        ScoreSign.GetComponent<ScoreManager>().Score(score);
    }
}
