using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsController : MonoBehaviour
{
    Rigidbody thisRigidbody;
    public Camera thisCamera;

    public float fpForwardBackward;
    public float fpStrafe;

    public float mouseY;
    public float mouseX;

    public Vector3 inputVelocity;
    public float velocityModifier;

    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        if(GameManager.instance.movement == true){
        mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX, 0);
        
        mouseY = Input.GetAxis("Mouse Y");
        thisCamera.transform.Rotate(-mouseY, 0, 0);

        fpForwardBackward = Input.GetAxis("Vertical");
        fpStrafe = Input.GetAxis("Horizontal");

        inputVelocity = transform.forward * fpForwardBackward;
        inputVelocity += transform.right * fpStrafe;   
        }                                        
    }

    void FixedUpdate()
    {
        thisRigidbody.velocity = (inputVelocity * velocityModifier + Physics.gravity * .69f);
    }

    void OnTriggerStay(Collider col){
        
      if(col.gameObject.name == "endCol"){

          GameManager.instance.endOpt = true;

      } else{
          GameManager.instance.endOpt = false;
      }

    }
}
