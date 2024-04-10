using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] shipsVariantes;
    float timeBtWSpawn;
    public float startTimeBtWSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        if (timeBtWSpawn <= 0)
        {
            int rand = Random.Range(0, shipsVariantes.Length);
            Instantiate(shipsVariantes[rand], transform.position, Quaternion.identity);

            timeBtWSpawn = startTimeBtWSpawn;

            //if (startTimeBtWSpawn > minTime)
            //{
            //    startTimeBtWSpawn -= decreaseTime;
            //}

        }
        else
        {
            timeBtWSpawn -= Time.deltaTime;
        }
        
    }
}
