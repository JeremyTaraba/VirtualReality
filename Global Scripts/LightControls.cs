using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LightControls : MonoBehaviour
{
   
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;

    private float timer;

    private bool isOnLight1;
    private bool isOnLight2;
    private bool isOnLight3;
    private bool isOnLight4;
    

    // Start is called before the first frame update
    void Start()
    {
        light1.GetComponent<Light>().enabled = false;
        light2.GetComponent<Light>().enabled = false;
        light3.GetComponent<Light>().enabled = false;
        light4.GetComponent<Light>().enabled = false;
        isOnLight1 = false;
        isOnLight2 = false;
        isOnLight3 = false;
        isOnLight4 = false;
        timer = 3;
    }

    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer >= 3.0){
            int rand = Random.Range(1,5);
            if((rand == 1) && (isOnLight1 == false)){
                light1.GetComponent<Light>().enabled = true;
                light2.GetComponent<Light>().enabled = false;
                light3.GetComponent<Light>().enabled = false;
                light4.GetComponent<Light>().enabled = false;
                isOnLight1 = true;
                isOnLight2 = false;
                isOnLight3 = false;
                isOnLight4 = false;
            }
            else if((rand == 1) && (isOnLight1 == true)){
                rand = 2;
            }
            if((rand == 2) && (isOnLight2 == false)){
                light2.GetComponent<Light>().enabled = true;
                light1.GetComponent<Light>().enabled = false;
                light3.GetComponent<Light>().enabled = false;
                light4.GetComponent<Light>().enabled = false;
                isOnLight1 = false;
                isOnLight2 = true;
                isOnLight3 = false;
                isOnLight4 = false;

            }
            else if((rand == 2) && (isOnLight2 == true)){
                rand = 3;
            }
            if((rand == 3) && (isOnLight3 == false)){
                light3.GetComponent<Light>().enabled = true;
                light2.GetComponent<Light>().enabled = false;
                light1.GetComponent<Light>().enabled = false;
                light4.GetComponent<Light>().enabled = false;
                isOnLight1 = false;
                isOnLight2 = false;
                isOnLight3 = true;
                isOnLight4 = false;   
            }
            else if((rand == 3) && (isOnLight3 == true)){
                rand = 4;
            }
            if((rand == 4) && (isOnLight4 == false)){
                light4.GetComponent<Light>().enabled = true;
                light2.GetComponent<Light>().enabled = false;
                light3.GetComponent<Light>().enabled = false;
                light1.GetComponent<Light>().enabled = false;
                isOnLight1 = false;
                isOnLight2 = false;
                isOnLight3 = false;
                isOnLight4 = true;
            }
            else if((rand == 4) && (isOnLight4 == true)){
                light1.GetComponent<Light>().enabled = true;
                light2.GetComponent<Light>().enabled = false;
                light3.GetComponent<Light>().enabled = false;
                light4.GetComponent<Light>().enabled = false;
                isOnLight1 = true;
                isOnLight2 = false;
                isOnLight3 = false;
                isOnLight4 = false;
            }
            timer = 0;
        }
        //if timer turned the light on but collider turned the light component off
        //then someone triggered it and switch to next light 
        if(isOnLight1 && !light1.GetComponent<Light>().enabled){
            timer = 3;
        }
        else if(isOnLight2 && !light2.GetComponent<Light>().enabled){
            timer = 3;
        }
        else if(isOnLight3 && !light3.GetComponent<Light>().enabled){
            timer = 3;
        }
        else if(isOnLight4 && !light4.GetComponent<Light>().enabled){
            timer = 3;
        }
    }
}
