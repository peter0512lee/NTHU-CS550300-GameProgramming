using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBrightness : MonoBehaviour
{
    public Light point_light;

    // Start is called before the first frame update
    void Start()
    {
        point_light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        point_light.intensity = Mathf.PingPong(Time.time, 8);
    }
}
