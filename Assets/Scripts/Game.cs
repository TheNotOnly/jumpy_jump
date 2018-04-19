using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Player player;
    private int stackScore = 0;
    public NewBlock NewBlock;
    public TimerClock timer;

    //    public TouchBox touchbox;

    // Use this for initialization
    private void Start()
    {
        timer.StartTimer();
    }

    // Update is called once per frame
    private void Update()
    {
        if (player.touch == true && Input.GetMouseButtonDown(0))
        {
            NewBlock.AddBlock();
            player.Jump();
            stackScore++;
        }
    }
}
