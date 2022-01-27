using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTime : MonoBehaviour
{ 
    
    public float lifetime;
    // Start is called before the first frame update
    void Start()
    {
         Destroy(gameObject, lifetime);
    }
       
    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Boulder").Length;
        if (count < 10)
        {
            lifetime = 50;
            
        }
        else
        {
            lifetime = 3;
            
        }
       

    }
}
