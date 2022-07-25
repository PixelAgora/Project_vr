using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Contains contains = gameObject.GetComponentInChildren<Contains>();
        /*sc.someValue = false;
        sc.someFunction();*/

        Check check = gameObject.GetComponentInChildren<Check>();
        /*sc.someValue = false;
        sc.someFunction();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
