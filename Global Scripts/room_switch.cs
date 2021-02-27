using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_switch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //turn on Auto Sync Transforms in the physics settings of the project
        if(Input.GetKeyDown("2")){
            this.transform.position =  new Vector3 (93, 1, 100);
        }
        if(Input.GetKeyDown("1")){
            this.transform.position =  new Vector3 (0, 1, 0);
        }
        if (Input.GetKeyDown (KeyCode.Escape)) {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
