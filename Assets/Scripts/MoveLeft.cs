using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float moveSpeed = 20f;
    private PlayerController playerControllerScript;
    private float outOfBounds = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (transform.position.x < outOfBounds && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        } 
    }
}
