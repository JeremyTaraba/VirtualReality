using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCollider : MonoBehaviour
{

    public PlayPause playPause;
    private bool inTrigger;
    // Start is called before the first frame update
    void Start()
    {
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
        if(Input.GetKeyDown("f") && inTrigger){
            playPause.PlayandPause();
        }
    }
}
