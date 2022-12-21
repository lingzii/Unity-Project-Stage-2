using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerControl : MonoBehaviour
{
    public float jumpHeight = 5f;
    public float speed = 5f;
    private int count = 0;

    public TextMeshProUGUI countText;
    private Rigidbody rb;
    private Vector3 move;
    private float force = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");
        move.Normalize();

        if (Input.GetKey(KeyCode.Space))
        {
            force += force < 2 ? Time.deltaTime : 0;
        }
        if (Input.GetKeyUp(KeyCode.Space)) // && Mathf.Abs(rb.velocity.y) < 0.1f
        {
            rb.velocity = new Vector3(0f, force * jumpHeight, 0f);
            force = 1;
        }

        // 向量轉移
        // move = Vector3.RotateTowards(transform.forward, move, speed * Time.deltaTime, 0f);
        // move = Quaternion.LookRotation(move);

        rb.MovePosition(rb.position + move);
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
