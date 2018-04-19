using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheStack : MonoBehaviour {

    private GameObject[] theStack;
    public Player player;
    public float force=200f;
    private int stackIndex;
    private int stackScore = 0;
    bool timerStart = false;
    public float timer = 5f;
    private float resetTime;

//    public TouchBox touchbox;

	// Use this for initialization
	private void Start () {
        theStack = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            theStack[i] = transform.GetChild(i).gameObject;
        stackIndex = transform.childCount - 1;

    }
	
	// Update is called once per frame
	private void Update () {
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
                theStack[stackIndex].transform.localPosition = new Vector3(0, stackScore, 0);
//                touchbox.transform.localPosition = new Vector3(0, stackScore, 0);
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
