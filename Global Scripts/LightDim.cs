using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{

    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;

    private bool inTrigger;
    private bool lightOn;
    private bool turnLightOff;
   
    // Start is called before the first frame update
    void Start()
    {
        light1.GetComponent<Light>();
        light2.GetComponent<Light>();
        light3.GetComponent<Light>();
        light4.GetComponent<Light>();
        lightOn = true;
        inTrigger = false;
        turnLightOff = false;
    }

    void OnTriggerEnter(Collider other){
        //Debug.Log("entered trigger");
        inTrigger = true;
    }

    void OnTriggerExit(Collider other){
        //Debug.Log("exitted trigger");
        inTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(turnLightOff && (light1.intensity > 0.2f)){
            light1.intensity += -0.01f;
            light2.intensity += -0.01f;
            light3.intensity += -0.01f;
            light4.intensity += -0.01f;
        }
        else if(!turnLightOff && (light1.intensity < 1)){
            light1.intensity += 0.01f;
            light2.intensity += 0.01f;
            light3.intensity += 0.01f;
            light4.intensity += 0.01f;
        }

        if(Input.GetKeyDown("q") && inTrigger && lightOn){
            turnLightOff = true;
            lightOn = false;
        }
        else if(Input.GetKeyDown("q") && inTrigger && !lightOn){
            turnLightOff = false;
            lightOn = true;
        }
    }
}
