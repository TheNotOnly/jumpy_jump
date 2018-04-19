using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Player player;
    public float force = 300f;
    private int stackScore = 0;
    bool timerStart = false;
    public float timer = 0.5f;
    private float resetTime;
    public GameObject floor;
    public float difficulty=1f;
    int counter=1;

    GameObject newFloor;

    //    public TouchBox touchbox;

    // Use this for initialization
    private void Start()
    {
        newFloor = floor;
    }

    // Update is called once per frame
    private void Update()
    {
        if (player.touch == true && Input.GetMouseButtonDown(0))
        {
            Pos();
            Jump();
            stackScore++;
        }

        if (player.touch == false)
        {
            newFloor.transform.position = Vector3.Lerp(newFloor.transform.position, new Vector3(0, newFloor.transform.position.y, 0), Time.deltaTime * difficulty);
        }


    }

    private void Pos()
    {
        float temp = Random.Range(0.0f, 10.0f);
        if (temp <= 4)
            x = -2.5f;
        if (temp >= 5)
            x = 2.5f;
    }

    public void Jump()
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

    private void MoveBlock()
    {

    }
}
