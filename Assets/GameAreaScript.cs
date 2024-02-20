using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAreaScript : MonoBehaviour
{
    public LogicScript logic;
    public BirdScript bird;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    // Make game end when bird leaves the trigger volume (screen)
    void OnTriggerExit2D(Collider2D other)
    {
        logic.gameOver();
        bird.birdIsAlive = false;
    }
}
