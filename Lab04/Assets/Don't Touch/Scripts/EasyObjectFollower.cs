using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyObjectFollower : MonoBehaviour
{
    public Vector3 offset;
    public float dampTime;

    public GameObject player;
    private Vector3 velocity;

    void FixedUpdate()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 camPos = new Vector3(playerPos.x + offset.x, offset.y, playerPos.z + offset.z);

		transform.position = Vector3.SmoothDamp(transform.position, camPos, ref velocity, dampTime);
    }
}
