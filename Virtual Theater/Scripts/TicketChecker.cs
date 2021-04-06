using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicketChecker : MonoBehaviour
{

    public Text WallExists;
    private int numWallExists;  //just a bool to check if wall exists

    public Text score;
    private int numScore;
    private bool inTrigger;
    private bool isWallThere;
    public GameObject wall;
    public Text wallText;

    public AudioSource goodSound;
    public AudioSource badSound;
    // Start is called before the first frame update
    void Start()
    {
        inTrigger = false;
        isWallThere = true;
    }
    void OnTriggerEnter(Collider other){
        //Debug.Log("entered trigger");
        inTrigger = true;
        numWallExists = int.Parse(WallExists.text);
        if(numWallExists == 1){
            isWallThere = true;
        }
    }

    void OnTriggerExit(Collider other){
        //Debug.Log("exitted trigger");
        inTrigger = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("f") && inTrigger && isWallThere){
            numScore = int.Parse(score.text);
            if(numScore > 0){
                numScore--;
                score.text = numScore.ToString();
                wall.SetActive(false);
                wallText.enabled = false;
                isWallThere = false;
                numWallExists = 0;
                WallExists.text = numWallExists.ToString();
                //ding sound
                goodSound.Play();
            }
            else{
                //bzzt sound
                badSound.Play();
            }
           
        }
    }
}
