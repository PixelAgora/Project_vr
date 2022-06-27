using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Check : MonoBehaviour
{
    /*
    Is vase touching the making station?
    Is there a flower?
    Is vase correct?
    Is flower correct?
1. Have it checked f flower and vase are on the station
2. Have it chcecked if its the correct flower and vase
3. Have it define which order is the current one (without changing scenes)
4. Make after the order gain points.
5. Clean the making station
6. Prefabs are not  rigid body unless  touched
7. Display the text on UI
8. Change text on the UI
9. Make an exit button

Checking order
after
4,5,8
Before
1,2,3
Other scri[ts
6,9]

    */
    public bool IsVaseOnMakingStation;
    public bool IsThereaFlower;
    
    
    
    void Start()
    {
       //Setup FirstOrder();
    }
    public void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("VaseTag"))
            { 
                IsVaseOnMakingStation = true;
                Debug.Log("True");
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
