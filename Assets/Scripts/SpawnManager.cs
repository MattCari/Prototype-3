using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    private Vector3 spawnPos = new Vector3(25, 0.12f, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacles", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnObstacles()
    {
        int obstaclesIndex = Random.Range(0, obstacles.Length);
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstacles[obstaclesIndex], spawnPos, obstacles[obstaclesIndex].transform.rotation);
        }
        
    }
}
