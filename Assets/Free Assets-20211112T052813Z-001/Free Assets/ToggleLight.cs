using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public Light light;
    bool lightOn = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(lightOn == false)
            {
                light.enabled = true;
                lightOn = true;
            }
            else
            {
                light.enabled = false;
                lightOn = false;
            }
        }
    }
}
