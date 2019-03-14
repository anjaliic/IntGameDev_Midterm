using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflyMovement : MonoBehaviour
{
     public float maxVelocity;
     
     public float xMin;
     public float xMax;

     public float yMin;
     public float yMax;

     public float zMax;
     public float zMin;
  
     private float x;
     private float y;
     private float z;

     private float startX;
     private float startY;
     private float startZ;

     private float time;
     private float angle;
     private float dir;
 
     // Use this for initialization
     void Start () {
         x = Random.Range(-maxVelocity, maxVelocity);
         z = Random.Range(-maxVelocity, maxVelocity);
         y = Random.Range(-maxVelocity, maxVelocity);

         startX = Random.Range(xMin, xMax);
         startY = Random.Range(yMin, yMax);
         startZ = Random.Range(zMin, zMax);

         //transform.position = new Vector3(startX, startY, startZ);
        
         dir = Random.value > 0.5f ? 1f : -1f;
         angle = Mathf.Atan2(x, z) * (180 / 3.141592f) + 90;
         transform.localRotation = Quaternion.Euler( 0, angle, 0);
     }
     
     // Update is called once per frame
     void Update () {
 
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
         transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y + y, transform.localPosition.z + z);
    }
}
