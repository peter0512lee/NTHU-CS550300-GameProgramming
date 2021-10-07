using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() 
    {
        float xDirection = Input.GetAxis("Vertical");
        float zDirection = Input.GetAxis("Horizontal");

        float speed = 0.1f;
        float jumpSpeed = 10.0f;
        float gravity = 20.0f;

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) {

            Vector3 PlayerDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            transform.rotation = Quaternion.LookRotation(PlayerDirection);
            transform.position += PlayerDirection * speed;
        }
        
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.R)) {
            gameObject.transform.position = new Vector3(0, 0, 0);
        }
        if(transform.position.y < -1.0f) {
            gameObject.transform.position = new Vector3(0, 0, 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        isGrounded = true;
    }

    void OnCollisionStay(Collision other) {

        isGrounded = true;
    }

    void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }
    
}
