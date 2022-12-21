using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCam : MonoBehaviour
{
    public Transform player;
    public Transform playerObj;
    public Transform orientation;
    public Transform combatLookAt;
    public GameObject combatCam;
    public Rigidbody rb;
    public float rotationSpeed;

    void Update()
    {
        Vector3 viewDir =
            player.position
            - new Vector3(transform.position.x, player.position.y, transform.position.z);
        orientation.forward = viewDir.normalized;

        Vector3 dirToCombatLookAt =
            combatLookAt.position
            - new Vector3(transform.position.x, combatLookAt.position.y, transform.position.z);
        orientation.forward = dirToCombatLookAt.normalized;

        player.forward = dirToCombatLookAt.normalized;
    }
}
