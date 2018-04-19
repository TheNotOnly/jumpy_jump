using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpdate : MonoBehaviour {

    public float move = 0.7f;
    public float transitionSpeed = 1f;
    public Player player;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y > transform.position.y - 3)
        {
            Vector3 newPos = new Vector3(transform.position.x, transform.position.y + move, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * transitionSpeed);
        }
    }

}