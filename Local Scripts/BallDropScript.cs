using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    
    void Start()
    {
        ball.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other){
        ball.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
