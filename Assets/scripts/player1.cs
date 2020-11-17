using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);

    }

    void FixedUpdate()
    {

    }
    public void moveForward(double speed)
    {
        rb.velocity = transform.forward;
    }
    public void turnRight()
    {
        rb.transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
    }
    public void turnLeft()
    {
        rb.transform.Rotate(0.0f, -90.0f, 0.0f, Space.World);

    }
    public bool isFalling()
    {
        return rb.position.y < 0;
    }
}
