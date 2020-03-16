using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Text scoreText;
    public float scoreCount;
	
	void Update () {
        scoreText.text = Mathf.Round(scoreCount).ToString();
	}

    public void Score(float val)
    {
        Debug.Log("add " + val + "to score");
        scoreCount += val;
        Debug.Log("new score: " + scoreCount);
    }
}
