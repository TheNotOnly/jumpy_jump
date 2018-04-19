using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject trailObject;
    public bool touch;
    public float force = 300f;

    // Use this for initialization
    void Start () {
        trailObject.SetActive(false);
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
        if (collision.gameObject.name != null)
        {
            DeactivateTrail();
            touch = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name != null)
        {
            ActivateTrail();
            touch = false;
        }
    }

    public void Jump()
    {
        GetComponent<Rigidbody>().AddForce(transform.up * force);
    }
}
