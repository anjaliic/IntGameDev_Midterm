using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflyController : MonoBehaviour
{
     public GameObject jar;

     public GameObject firefly;
     public Transform fireflyT;

     public GameObject lid;
     public GameObject lidColl;

     public bool lidOn = true;
     public bool caught = false;

     private float speed = 5f;

     Vector3 movement;

     private float x;
     private float y;
     private float z;

     public float xMin = -15;
     public float xMax = 15;

     public float yMin = 0;
     public float yMax = 5;

     public float zMin = -9;
     public float zMax = 35;

    // Start is called before the first frame update
    void Start()
    {
       jar = GameObject.Find("jar");

       fireflyT = this.transform;
       firefly = this.gameObject;

       //- - - movement

        x = Random.Range(-speed, speed);
        z = Random.Range(-speed, speed);
        y = Random.Range(-speed, speed);
        
        movement = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update(){

        transform.Translate(movement * Time.deltaTime);
         
    }

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "wall"){
            movement *= -1;
        }

    }

      void OnTriggerStay(Collider other){
    
        if(other.gameObject.name == "player"){

        if(Input.GetKeyDown(KeyCode.E)){

            this.caught = true;

            this.fireflyT.transform.position = jar.transform.position;

            transform.GetComponent<SphereCollider>().enabled = false;
            //transform.GetComponent<Rigidbody3D>().enabled = false;
            //transform.GetComponent<BoxCollider>().enabled = false;
            //transform.GetComponent<Rigidbody>().useGravity = true;

        }
      }   

    }
}
