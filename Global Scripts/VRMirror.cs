using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour
{

    public Transform Controller;
    private Vector3 offsetDistance;
    private bool mirror;

    Vector3 mirrorPosition;
     float rotationSpeed = 45;
    Vector3 currentEulerAngles;

    
    // Start is called before the first frame update
    void Start()
    {
        mirror = true;
        offsetDistance = Controller.position - transform.position;
        mirrorPosition = transform.position;
    }

    // Update is called once per frame
    
    void Update()
    {
        if(Input.GetKeyDown("m") && mirror == false){
            mirror = true;
        }
        else if(Input.GetKeyDown("m") && mirror == true){
            mirror = false;
        }
        if(mirror == false){
            transform.position = Controller.position - offsetDistance;
            Vector3 r;
            r.x = Camera.main.transform.localEulerAngles.x * -1.0f;
            r.y = Controller.localEulerAngles.y + 180.0f;
            r.z = Controller.localEulerAngles.z;
            transform.localEulerAngles = r;
            
        }
        if(mirror == true){
            transform.localRotation = 
            new Quaternion(Camera.main.transform.localRotation.x * -1.0f,
                            Controller.localRotation.y * -1.0f,
                            Controller.localRotation.z * -1.0f,
                            Controller.localRotation.w);

            mirrorPosition.x = Controller.position.x - offsetDistance.x;
            mirrorPosition.y = Controller.position.y - offsetDistance.y;
            mirrorPosition.z = Controller.position.z + offsetDistance.z;
     
            transform.position = Vector3.Reflect(mirrorPosition, Vector3.forward);

            
            //Camera.main.transform
        }
    }
}
