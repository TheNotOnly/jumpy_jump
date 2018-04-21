using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public TimerClock timer;
    public NewBlock newblock;
    public Game game;

    public GameObject trailObject;
    public bool touch;
    public float force = 300f;
    
    // Use this for initialization
    void Start () {
        trailObject.SetActive(false);
        touch = true;
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void ActivateTrail()
    {
        trailObject.SetActive(true);
    }

    public void DeactivateTrail()
    {
        trailObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor(Clone)" )
        {
            DeactivateTrail();
            touch = true;
            timer.StartTimer();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Floor(Clone)")
        {
            ActivateTrail();
            touch = false;
            timer.StopResetTime();
            newblock.blockmove = false;
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody>().AddForce(transform.up * force);
    }
}
