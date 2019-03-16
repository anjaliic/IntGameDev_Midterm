using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflyCatch : MonoBehaviour
{
   public GameObject jar;
   public GameObject movementScript;

   public GameObject firefly;
   public Transform fireflyT;

   public bool lid = true;
   public bool caught = false;

    void Start()
    {
       jar = GameObject.Find("jar");

       fireflyT = this.transform;
       firefly = this.gameObject;

       //movementScript = GetComponent(fireflyMovement);
    }

    void OnTriggerStay(Collider other){
    
        if(other.gameObject.name == "player"){

        if(Input.GetKeyDown(KeyCode.E)){

            caught = true;
            
            fireflyT.transform.position = jar.transform.position;

            transform.GetComponent<SphereCollider>().enabled = false;
            transform.GetComponent<Rigidbody>().isKinematic = false;
            transform.GetComponent<Rigidbody>().useGravity = true;

            //disable firefly movement
            //movementScript.enabled = false;

        }
      }   

    }
}
