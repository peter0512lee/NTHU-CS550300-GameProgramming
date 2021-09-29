using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerComplete : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){
                
        float moveVertical = Input.GetAxis ("Vertical");
        float speed = 3.0f;
        rb.velocity =  gameObject.transform.forward * speed * moveVertical + new Vector3(0, rb.velocity.y, 0);
        
        if(Input.GetKey(KeyCode.A)){
            gameObject.transform.Rotate(new Vector3(0, -2.0f, 0));
        }if(Input.GetKey(KeyCode.D)){
            gameObject.transform.Rotate(new Vector3(0, 2.0f, 0));
        }

        rb.angularVelocity = Vector3.zero;
    }
}
