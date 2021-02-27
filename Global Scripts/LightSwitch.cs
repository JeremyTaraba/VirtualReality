using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    bool curLightColor;
    public Light p_light;
    

    // Start is called before the first frame update
    void Start()
    {
        p_light = GetComponent<Light> ();
        curLightColor = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown ("tab") && curLightColor){
            p_light.color = new Color(0.7f, 0.45f, 0.04f, 1f);
            curLightColor = false;
        }
        else if(Input.GetKeyDown ("tab") && !curLightColor){
            p_light.color = new Color(0.9f, 0.9f, 0.9f, 1f);
            curLightColor = true;
        }
    }
}
