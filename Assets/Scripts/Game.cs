using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Player player;
    private int stackScore = 0;
    public NewBlock NewBlock;
    public TimerClock timer;
    public bool onFloor = true;

    //    public TouchBox touchbox;

    // Use this for initialization
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (player.touch == true && Input.GetMouseButtonDown(0))
        {
            if (onFloor == true)
            {
                timer.StartTimer();
                NewBlock.AddBlock();
                onFloor = false;
                player.touch = false;
            }
            player.Jump();
            stackScore++;
        }
    }
}
