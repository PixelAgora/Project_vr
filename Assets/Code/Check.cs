using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Check : MonoBehaviour
{
    
    void Start()
    {
       //FirstOrder();
    }
    public void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("VaseTag"))
            { 
                Debug.Log("done");
            }
    }
    public void FirstOrder()
    {
        
        //blue, brown
    }

    public void SecondOrder()
    {
        //pink, green
    }
}
