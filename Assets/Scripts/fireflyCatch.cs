using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflyCatch : MonoBehaviour
{
   public GameObject jar;
   public Transform firefly;


    // Start is called before the first frame update
    void Start()
    {
       firefly = this.transform;
    }

    void OnTriggerStay(Collider other){

        if(Input.GetKeyDown(KeyCode.E)){
            
            transform.position = jar.transform.position;

            transform.GetComponent<SphereCollider>().enabled = false;
            transform.GetComponent<Rigidbody>().isKinematic = false;

        }   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
