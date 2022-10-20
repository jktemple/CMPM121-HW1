using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{


    // //movement speed in units per second
    public float movementSpeed = 10f;
    public Vector3 moveDirection = new Vector3(1f,0f,0f);

    private Vector3 begining;

    void Awake(){
        begining = transform.position;
    }

    void Update()
     {

        //update the position
        if(GetComponent<Camera>().enabled){
         transform.position = transform.position + moveDirection* movementSpeed * Time.deltaTime;
        } else {
            transform.position = begining;
        }
    }
}
