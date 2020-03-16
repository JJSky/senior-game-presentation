using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour {

    public List<GameObject> availableItems;
    public float spawnSpeed = 1;
    public float numberOfItems = 10;
    private float spawnCount = 0;

	void Start () {
        StartCoroutine("SpawnDelay");
	}

    private IEnumerator SpawnDelay()
    {
        yield return new WaitForSeconds(spawnSpeed);
        int randIndex = Random.Range(0, availableItems.Count);
        Instantiate(availableItems[randIndex], this.gameObject.transform.position, availableItems[randIndex].gameObject.transform.rotation);
        spawnCount++;

        if(spawnCount >= numberOfItems)
        {
            StopCoroutine("SpawnDelay");
        }
        else
        {
            StartCoroutine("SpawnDelay");
        }
    }
}
