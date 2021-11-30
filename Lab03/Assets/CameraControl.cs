using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");
            transform.position = transform.position + new Vector3(0, 0, 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
            transform.position = transform.position + new Vector3(0, 0, -10);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("up");
            transform.position = transform.position + new Vector3(0, 10, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("down");
            transform.position = transform.position + new Vector3(0, -10, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("left");
            transform.position = transform.position + new Vector3(-10, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("right");
            transform.position = transform.position + new Vector3(10, 0, 0);
        }
    }
}
