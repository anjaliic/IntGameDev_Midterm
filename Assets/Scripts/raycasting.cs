using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasting : MonoBehaviour
{

    public float rayDistance = 2;

    void Update()
    {
        Ray myRay  = new Ray(this.transform.position, Vector3.down);

        Debug.DrawRay(myRay.origin, new Vector3(0, -rayDistance, 0), (Color.red));

        RaycastHit myHit;

//        if(Physics.Raycast(myRay, rayDistance, out myHit, rayDistance)){
           
            print("ray is hitting smth");
           // transform.Rotate(0,1,0);
       //  } else{
       //     transform.Rotate(0, 0, 0);
        //}
    }
}
