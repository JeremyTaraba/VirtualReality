using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableWall : MonoBehaviour
{
    // Start is called before the first frame update
    public Text WallExists;
    private int numWallExists;  //just a bool to check if wall exists
    public GameObject wall;
    public Text wallText;
    private bool inTrigger;
    private bool wentInTheater;
    void Start()
    {
        inTrigger = false;
        wentInTheater = false;
    }

    void OnTriggerEnter(Collider other){
        //Debug.Log("entered trigger");
        inTrigger = true;
        numWallExists = int.Parse(WallExists.text);
        if(numWallExists == 0){
            wall.SetActive(true);
            wallText.enabled = true;
            numWallExists = 1;
            WallExists.text = numWallExists.ToString();
        }
    }

    void OnTriggerExit(Collider other){
        //Debug.Log("exitted trigger");
        inTrigger = false;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
