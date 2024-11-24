using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemySpawner : MonoBehaviour
{
   public GameObject enemyPrefab;

    public float spawnrate = 2f;

    public float minXAispawnValue;
    public float maxXAispawnValue;

    public float yAXisSpawnValue = 4f;

    private float timeSinceLastAction = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Al=
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        float xPosition = Random.Range(minXAispawnValue, maxXAispawnValue);
        Vector3 spawnPosition = new Vector3(xPosition, yAxisSpawnValue);
    }


}
