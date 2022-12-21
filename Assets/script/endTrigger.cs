using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public playerControl script;
    public Rigidbody player_rb;

    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody == player_rb)
        {
            Debug.Log(script.count);
            if (script.count >= 50)
            {
                // Game over
            }
        }
    }
}
