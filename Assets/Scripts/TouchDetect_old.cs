using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDetect : MonoBehaviour {

    public Player player;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name== "Tile (8)")
        {
            player.ActivateTrail();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Tile (8)")
        {
            player.DeactivateTrail();
        }
    }

    

}
