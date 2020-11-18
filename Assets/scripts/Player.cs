using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public double speed;
    CharacterController controller;
	Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
		controller = GetComponent<CharacterController>();
		anim = GetComponent<Animator>();
        anim.SetBool("running", true);
        anim.SetInteger("condition", 1);
        speed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(0,0,(float) (Time.deltaTime * speed));

    }

    void FixedUpdate(){
        speed+=.01;
    }
    public void moveForward(double speed){
        rb.velocity = transform.forward;
    }
    public void turnRight(){
        rb.transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
    }
    public void turnLeft(){
        rb.transform.Rotate(0.0f, -90.0f, 0.0f, Space.World);
        
    }
    public bool isFalling(){
        return rb.position.y < 0;
    }
}
