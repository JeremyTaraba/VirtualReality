using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collider1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Light light1;

    public Text score;

    private int numScore;

    private bool inTrigger;
    void Start()
    {
        light1.GetComponent<Light>();
        inTrigger = false;
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
        if(Input.GetKeyDown("e") && inTrigger && light1.GetComponent<Light>().enabled){
            numScore = int.Parse(score.text);
            numScore++;
            score.text = numScore.ToString();
            light1.GetComponent<Light>().enabled = false;
        }
    }
}
