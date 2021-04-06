using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TicketCollider : MonoBehaviour
{

    public Text score;
    private int numScore;
    private bool inTrigger;
    public AudioSource goodSound;
    public AudioSource badSound;


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
            numScore = int.Parse(score.text);
            if(numScore < 4){
                numScore++;
                score.text = numScore.ToString();
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
