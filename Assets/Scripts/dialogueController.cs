using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueController : MonoBehaviour
{
    public Image img1;
    public Image img2;
    
    public Text myText;
    public Text instruc;

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
            instruc.text = "";
            GameManager.instance.movement = true;
        }

        if(GameManager.instance.movement == true){

        if(GameManager.instance.endOpt == true){
            img1.enabled = true;
            img2.enabled = true;
            myText.text = "Ready to head back inside?";
            instruc.text = "Press SPACE to end";
        }else if(GameManager.instance.endOpt != true){

            img1.enabled = false;
            img2.enabled = false;
            myText.text = "";
            instruc.text = "";

        }

        }
    }

}
