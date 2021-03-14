using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpeed : MonoBehaviour
{
    public float minSpeed = 100f;
    public float maxSpeed = 800f;
    public Rigidbody2D rb;
    float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.deltaTime * speed);
    }

    public void AdjustSpeed (float newSpeed)
    {
        speed = newSpeed;
    }
}
