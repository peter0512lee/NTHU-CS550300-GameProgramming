using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootCounter : MonoBehaviour
{
    GameObject[] shoot;
    public Text shootCountText;

    // Update is called once per frame
    void Update()
    {
        shoot = GameObject.FindGameObjectsWithTag("Ball");

        shootCountText.text = "Shoot: " + shoot.Length.ToString() + "/3";
    }
}
