using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{

    public GameObject pipe;
    // Seconds elapsed for the next pipe to spawn in the game.
    public float spawnRate = 3;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            // Delta time keeps time consistent across all computers.
            timer += (Time.deltaTime);
        }
        else
        {
            spawnPipe();
            // Reset the timer back to zero
            timer = 0;
        }
       
    }

    void spawnPipe ()
    {
        // Higest and lowest points that the pipes can spawn.
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }
}
