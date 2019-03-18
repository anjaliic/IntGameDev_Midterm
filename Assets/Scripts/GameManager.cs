using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public int score = 0;

    public bool movement = false;
    public bool 
    public bool endOpt = false;
    public bool endGame = false;

    void Awake(){
        if(instance == null){
            instance = this;
        }
        else if(instance != null){
            Destroy(gameObject);
        }
    }

    void Update(){
        if(endGame == true){

        }
    }

}
