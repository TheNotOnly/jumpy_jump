using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<Player>() != null)
            Debug.Log("FALL");
    }
}
