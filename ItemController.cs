using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {
    [Header("Weight")]
    public float weight;
    public float weightCanSupport;
    [Header("Score")]
    public float scoreSuccess;
    public float scoreFail;
    public float scoreCrush;

    private bool destroyed = false;

    private GameObject ScoreSign;

    void Awake()
    {
        ScoreSign = GameObject.Find("ScoreSign").gameObject;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 10 && !destroyed)
        {
            destroyed = true;
            ScoreSign.GetComponent<ScoreManager>().Score(scoreFail);
            Destroy(gameObject);
        }
    }
}
