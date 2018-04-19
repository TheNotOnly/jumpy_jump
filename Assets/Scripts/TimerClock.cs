using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerClock : MonoBehaviour {

    public NewBlock NewBlock;

    public float timer = 0.5f;
    bool timerStart = false;
    float resetTime;

	// Use this for initialization
	public void Start () {
        resetTime = timer;
	}
	
	// Update is called once per frame
	void Update () {
		if (timerStart == true)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                timer = resetTime;
                timerStart = false;
                NewBlock.AddBlock();
            }
        }
	}

    public void StartTimer()
    {
        timerStart = true;
    }
}
