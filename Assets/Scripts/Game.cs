using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Player player;
    public float force = 200f;
    private int stackScore = 0;
    bool timerStart = false;
    public float timer = 5f;
    private float resetTime;
    public Transform floor;

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
            Jump();
            Timer();
            stackScore++;
        }
        if (timerStart == true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Instantiate(floor, new Vector3(0, floor.transform.position.y + (stackScore * 0.3f), 0), Quaternion.identity);
                timerStart = false;
                timer = resetTime;
            }
        }

    }

    private void Jump()
    {
        player.GetComponent<Rigidbody>().AddForce(transform.up * force);
    }

    private void Timer()
    {
        if (timerStart == false)
        {
            resetTime = timer;
            timerStart = true;
        }
    }
}
