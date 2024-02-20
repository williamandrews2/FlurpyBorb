using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 7;

    // Position at the left end of the screen where we will destroy the pipes.
    public float deadZone = -35;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            // Same thing as console.log in JS. Found under console tab in Unity.
            Debug.Log("Pipe Deleted!");

            // Destroy actor (pipe) that hold this property.
            Destroy(gameObject);
        }
    }
}
