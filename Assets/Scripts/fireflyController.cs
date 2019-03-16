using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflyController : MonoBehaviour
{
     public GameObject jar;

     public GameObject firefly;
     public Transform fireflyT;

     public bool lid = true;
     public bool caught = false;

     public float speed = .05f;
     Vector3 movement;

     private float x;
     private float y;
     private float z;

     private float startX;
     private float startY;
     private float startZ;

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

        startX = Random.Range(xMin, xMax);
        startY = Random.Range(yMin, yMax);
        startZ = Random.Range(zMin, zMax);

        this.transform.position = new Vector3(startX, startY, startZ);
    }

    // Update is called once per frame
    void Update(){

         

    }
      void OnTriggerStay(Collider other){
    
        if(other.gameObject.name == "player"){

        if(Input.GetKeyDown(KeyCode.E)){

            this.caught = true;

            this.fireflyT.transform.position = jar.transform.position;

            transform.GetComponent<SphereCollider>().enabled = false;
            //transform.GetComponent<Rigidbody3D>().enabled = false;
            transform.GetComponent<BoxCollider>().enabled = false;
            //transform.GetComponent<Rigidbody>().useGravity = true;

        }
      }   

    }
}
