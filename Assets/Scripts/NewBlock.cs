using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlock : MonoBehaviour {

    public Player player;
    public TimerClock timer;

    public GameObject floor;
    GameObject newFloor;
    public int counter = 1;
    float x;
    public float difficulty = 1f;
    public bool blockmove = true;
    float[] difficultymult=new float[100];

    // Use this for initialization
    void Start () {
        newFloor = floor;
        difficultymult[0] = difficulty + 0;
        difficultymult[1] = difficulty + 2;
        difficultymult[2] = difficulty + 4;
        difficultymult[3] = difficulty + 6;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (counter <= 10)
            difficulty = difficultymult[0];
        if (counter > 10 && counter <= 15)
            difficulty = difficultymult[1];
        if (counter > 15 && counter <= 20)
            difficulty = difficultymult[2];
        if (counter > 20 && counter <= 55)
            difficulty = difficultymult[3];

        if (player.touch == false  || player.touch==true && blockmove==true)
        {
            newFloor.transform.position = Vector3.Lerp(newFloor.transform.position, new Vector3(0, newFloor.transform.position.y, 0), difficulty * 0.01f);
        }

        if (timer.timer <=0 && player.touch == true)
        {
            AddBlock();
            timer.StopResetTime();
            blockmove = true;
        }
    }

    public void AddBlock()
    {
        Pos();
        Vector3 newpos = new Vector3(x, floor.transform.position.y + (counter * 0.7f), 0);
        newFloor = Instantiate(floor, newpos, Quaternion.identity);
        counter++;
    }

    public void Pos()
    {
        float temp = Random.Range(0.0f, 10.0f);
        if (temp <= 4)
            x = Random.Range(-4f,-3f);
        if (temp >= 5)
            x = Random.Range(3f,4f);
    }
}
