using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ChairSitTheater1 : MonoBehaviour
{
    private bool inTrigger;
    private bool inChair;
    public FirstPersonController fpc; 

    // Start is called before the first frame update
    void Start()
    {
        fpc = GameObject.FindObjectOfType<FirstPersonController>();
        inTrigger = false;
        inChair = false;
    }

    void OnTriggerEnter(Collider other){
        inTrigger = true;
    }

    void OnTriggerExit(Collider other){
        inTrigger = false;
        inChair = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(inChair && inTrigger && (Input.GetKeyDown("w")|| Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown("f"))){
            //pop them out of the chair if they try to move
            fpc.transform.position =  new Vector3(this.transform.position.x + 1, this.transform.position.y + 1, this.transform.position.z);
            inChair = false;
        }
        else if(Input.GetKeyDown("f") && inTrigger && !inChair){
            //move player into chair
            //need to turn on Auto Sync Transforms in the physics settings of the project
            fpc.transform.position =  new Vector3 (this.transform.position.x + 0.2f, this.transform.position.y + 1, this.transform.position.z);
            inChair = true;
        }
    }
}
