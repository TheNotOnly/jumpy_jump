using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlock : MonoBehaviour {

    public Player player;

    public GameObject floor;
    GameObject newFloor;
    int counter = 1;
    float x;
    public float difficulty = 1f;

    // Use this for initialization
    void Start () {
        newFloor = floor;
	}
	
	// Update is called once per frame
	void Update () {
        if (player.touch == false)
        {
            newFloor.transform.position = Vector3.Lerp(newFloor.transform.position, new Vector3(0, newFloor.transform.position.y, 0), Time.deltaTime * difficulty);
        }
    }

    public void AddBlock()
    {
        Pos();
        newFloor = Instantiate(floor, new Vector3(x, floor.transform.position.y + (counter * 0.7f), 0), Quaternion.identity);
        counter++;
    }

    public void Pos()
    {
        float temp = Random.Range(0.0f, 10.0f);
        if (temp <= 4)
            x = Random.Range(-5f,-3f);
        if (temp >= 5)
            x = Random.Range(3f,5f);
    }
}
