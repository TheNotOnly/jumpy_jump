using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {

    public GameObject resetBox;
    public NewBlock newblock;
    Vector3 newresetpos;

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Player>() != null)
            SceneManager.LoadScene("Jumpy Jump");
    }

    private void Update()
    {
        newresetpos = new Vector3(transform.position.x, newblock.floor.transform.position.y + (newblock.counter * 0.7f), transform.position.z);
        transform.position = newresetpos;
    }
    
}
