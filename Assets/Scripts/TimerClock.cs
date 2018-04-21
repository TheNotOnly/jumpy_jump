using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerClock : MonoBehaviour {

    public NewBlock NewBlock;

    public float timer = 0.5f;
    bool timerStart = false;
    public float resetTime;

	// Use this for initialization
	public void Start () {
        resetTime = timer;
	}
	
	// Update is called once per frame
	void Update () {
		if (timerStart == true)
        {
            timer -= Time.deltaTime;
/*            if (timer <= 0)
           {
                ResetTimer();
            }
*/        }
	}

    public void StartTimer()
    {
        timerStart = true;
    }

    public void ResetTimer()
    {
        timer = resetTime;
    }

    public void StopTimer()
    {
        timerStart = false;
    }

    public void StopResetTime()
    {
        timerStart = false;
        timer = resetTime;
    }
}
