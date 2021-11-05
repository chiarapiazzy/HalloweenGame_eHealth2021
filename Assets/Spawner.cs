using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject pumpkinPrefab;

    public List<float> possiblePositions;

    public float startTimeBtwnSpawn;
    public float timeFromSpawn;

    private void Awake()
    {
        timeFromSpawn = startTimeBtwnSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFromSpawn <= 0)
        {
            int rand = Random.Range(0, possiblePositions.Count);
            Instantiate(pumpkinPrefab, new Vector3(8, possiblePositions.ElementAt(rand)), Quaternion.identity);
            timeFromSpawn = startTimeBtwnSpawn;
        }
        else
        {
            timeFromSpawn -= Time.deltaTime;
        }
    }
}
