using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 200f;
    public float rotationSpeed = 100f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        rb.velocity = ((transform.forward * vAxis) * speed * Time.deltaTime);
        transform.Rotate((transform.up * hAxis) * rotationSpeed * Time.deltaTime);
    }
}
