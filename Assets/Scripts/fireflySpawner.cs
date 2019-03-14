using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireflySpawner : MonoBehaviour
{
    public Transform firefly;
    
    public int spawnNum;
    
    private float x;
    private float y;
    private float z;

    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i < spawnNum; i++){

             x = Random.Range(-35f, 31f);
             y = Random.Range(-2.5f, 4f);
             z = Random.Range(-11f, 47f); 

            Instantiate(firefly, new Vector3(x, y, z), Quaternion.identity);
            Debug.Log("instantiated 1 firefly");

        }
    }

    void Update()
    {


    }
}
