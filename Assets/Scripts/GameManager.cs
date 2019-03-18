using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public int score = 0;

    public bool movement = false;
    public bool lid = true;
    public bool endOpt = false;

    public bool intro = true;
    public bool gameplay = false;
    public bool endGame = false;
    public bool loadNext = false;

    void Awake(){
        if(instance == null){
            instance = this;
        }
        else if(instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Update(){
        if(gameplay == true && loadNext == true){
            SceneManager.LoadScene("camp");
            loadNext = false;
        }
        if(endGame == true && GameManager.instance.loadNext == true){
            
             SceneManager.LoadScene("ending");
             loadNext = false;
             if(Input.GetKeyDown("space")){
                 gameplay = true;
                 loadNext = true;
             }
        }
    }

}
