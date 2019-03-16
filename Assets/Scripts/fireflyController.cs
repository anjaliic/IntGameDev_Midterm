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

    // - - - movement 

     public float maxVelocity = .1f;
     
     public float xMin = -50f;
     public float xMax = -48f;

     public float yMin = -3f;
     public float yMax = 1.2f;

     public float zMin = -14.8f;
     public float zMax = -12.3f;
  
     private float x;
     private float y;
     private float z;

     private float startX;
     private float startY;
     private float startZ;

     private float time;
     private float angle;
     private float dir;

    // Start is called before the first frame update
    void Start()
    {
       jar = GameObject.Find("jar");

       fireflyT = this.transform;
       firefly = this.gameObject;

       //- - - movement

        x = Random.Range(-maxVelocity, maxVelocity);
        z = Random.Range(-maxVelocity, maxVelocity);
        y = Random.Range(-maxVelocity, maxVelocity);

        startX = Random.Range(xMin, xMax);
        startY = Random.Range(yMin, yMax);
        startZ = Random.Range(zMin, zMax);

        transform.position = new Vector3(startX, startY, startZ);
        
        dir = Random.value > 0.5f ? 1f : -1f;
        angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
        transform.localRotation = Quaternion.Euler( 0, angle, 0);
    }

    // Update is called once per frame
    void Update(){

         time += Time.deltaTime;
 
         if (transform.localPosition.x > xMax) {
             x = Random.Range(-maxVelocity, 0.0f);
             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angle, 0);
             time = 0.0f; 
         }
         if (transform.localPosition.x < xMin) {
             x = Random.Range(0.0f, maxVelocity);
             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angle, 0); 
             time = 0.0f; 
         }
         if (transform.localPosition.z > zMax) {
             z = Random.Range(-maxVelocity, 0.0f);
             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angle, 0); 
             time = 0.0f; 
         }
         if (transform.localPosition.z < zMin) {
             z = Random.Range(0.0f, maxVelocity);
             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angle, 0);
             time = 0.0f; 
         }

         if(transform.position.y > yMax){
             dir = -1f;
         }
         if(transform.position.y < yMin){
             dir = 1f;
         }
 
         if (time > 1.0f) {
             x = Random.Range(-maxVelocity, maxVelocity);
             z = Random.Range(-maxVelocity, maxVelocity);
             y = Random.Range(-maxVelocity, maxVelocity);

             angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
             transform.localRotation = Quaternion.Euler(0, angle, 0);
             time = 0.0f;
         }
         //transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y + y, transform.localPosition.z + z);
    }
      void OnTriggerStay(Collider other){
    
        if(other.gameObject.name == "player"){

        if(Input.GetKeyDown(KeyCode.E)){

            this.caught = true;

            this.fireflyT.transform.position = jar.transform.position;

            this.zMax = -13.4f;
            this.zMin = -13.8f;

            this.yMin = -1.19f;
            this.yMax = -.7f;

            this.xMin =  -49.3f;
            this.xMax = -48.9f;

            transform.GetComponent<SphereCollider>().enabled = false;
            //transform.GetComponent<Rigidbody3D>().enabled = false;
            transform.GetComponent<BoxCollider>().enabled = false;
            //transform.GetComponent<Rigidbody>().useGravity = true;

            //disable firefly movement
            //movementScript.enabled = false;

        }
      }   

    }
}
