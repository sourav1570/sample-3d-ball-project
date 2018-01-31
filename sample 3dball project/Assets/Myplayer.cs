using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Myplayer : MonoBehaviour {

    private Rigidbody rb;

    public bool isGrounded;

    public float jump = 10f;

    public float rotationspeed = 300f;

    float Rotationspeed;
    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis("Horizontal") * rotationspeed;
        move *= Time.deltaTime;
        rb.AddRelativeTorque(Vector3.back * move);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(0, jump, 0, ForceMode.Impulse);
        }
        isGrounded = false;
    }

    }
 



