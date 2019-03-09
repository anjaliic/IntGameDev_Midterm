using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflyCatch : MonoBehaviour
{
   public GameObject jar;
   public Transform firefly;

    void Start()
    {
       firefly = this.transform;
    }

    void OnTriggerStay(Collider other){
    
        if(other.gameObject.name == "player"){

        if(Input.GetKeyDown(KeyCode.E)){
            
            firefly.transform.position = jar.transform.position;

            transform.GetComponent<SphereCollider>().enabled = false;
            transform.GetComponent<Rigidbody>().isKinematic = false;

        }
      }   

    }
}
