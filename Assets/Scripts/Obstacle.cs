using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float timeToDestroy;
    private float time = 0;
    [SerializeField] private float timeToRespawn = 3;
    [SerializeField] private GameObject obstacle;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
        time += Time.deltaTime;
        if (time >= timeToRespawn)
        {
            SpawnObstacle();
            time = 0;
        }

    }
    private void SpawnObstacle()
    {
        Instantiate(obstacle, new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), 0), Quaternion.identity);

    }
    private void RespawnObstacle()
    {


    }
}

