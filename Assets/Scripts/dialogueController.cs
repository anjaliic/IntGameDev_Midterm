using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueController : MonoBehaviour
{
    public Image img1;
    public Image img2;
    
    public Text myText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            img1.enabled = false;
            img2.enabled = false;
            myText.text = "";
        }
    }

}
