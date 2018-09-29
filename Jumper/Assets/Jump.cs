using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    Rigidbody rb;
    public int JumpHeight = 0;
    public int BallSpeed = 0;
    public bool inAir = false;

    void Start() {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKey(KeyCode.Space)) && !inAir)
        {
            rb.AddForce(transform.up * JumpHeight);
        }
    }


    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Platform")
            inAir = false;
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Platform")
            inAir = true;
    }

}
   