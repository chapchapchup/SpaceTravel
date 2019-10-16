using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    GameObject[] gameObjects = new GameObject[3]; 
    public GameObject planet1;
    public GameObject planet2;
    public GameObject planet3;
    public Vector3 spawnValues;
    public int planetCount;
    public float SpawnWait;
    public float startWait;


    void Start()
    {
        gameObjects[0] = planet1;
        gameObjects[1] = planet2;
        gameObjects[2] = planet3;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(startWait);
        
        while(true)
        {
            for (int i = 1; i < planetCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Instantiate(gameObjects[Random.Range(0,3)], spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(SpawnWait);
            }

        }
    }

}
