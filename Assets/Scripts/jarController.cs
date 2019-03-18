using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jarController : MonoBehaviour
{

    public GameObject lidObj;
    public GameObject lidColl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("left shift") || (Input.GetKeyDown("right shift"))){

            if(GameManager.instance.lid == true){
                GameManager.instance.lid = false;
            } else{
                GameManager.instance.lid = true;
            }

        }

        if(GameManager.instance.lid == false){
            lidObj.SetActive(false);
            lidColl.SetActive(false);
        }
        else if(GameManager.instance.lid == true){
            lidObj.SetActive(true);
            lidColl.SetActive(true);
        }
        
    }
}
