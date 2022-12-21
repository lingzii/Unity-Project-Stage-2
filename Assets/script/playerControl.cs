using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerControl : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public float jumpHeight = 5f;
    public float maxSpeed = 10f;
    public float speed = 1f;
    public int count = 0;

    private Rigidbody rb;
    private Vector3 move;
    private float force = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 localForward = transform.TransformDirection(Vector3.forward);
        Vector3 localRight = transform.TransformDirection(Vector3.right);

        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");
        move.Normalize();

        if (Input.GetKey(KeyCode.Space))
        {
            force += force < 2 ? Time.deltaTime : 0;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.velocity = new Vector3(0f, force * jumpHeight, 0f);
            force = 1;
        }

        if (rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(move.z * speed * localForward);
            rb.AddForce(move.x * speed * localRight);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            count += 1;
            countText.text = "Count: " + count.ToString();
            other.gameObject.SetActive(false);
        }
    }
}
