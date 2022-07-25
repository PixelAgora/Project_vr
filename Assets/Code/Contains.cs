
//Attach this script to a GameObject with a Collider component
//Create an empty GameObject (Create>Create Empty) and attach it in the New Transform field in the Inspector of the first GameObject
//This script tells if a point  you specify (the position of the empty GameObject) is within the first GameObject’s Collider

using UnityEngine;

public class Contains : MonoBehaviour
{
    //Make sure to assign this in the Inspector window
    public Transform NewTransform;
    Collider Collider;
    Vector3 kwiatek;

    void Start()
    {
        //Fetch the Collider from the GameObject this script is attached to
        Collider = GetComponent<Collider>();
        //Assign the point to be that of the Transform you assign in the Inspector window
        kwiatek = NewTransform.position;
    }

    void Update()
    {
        //If the first GameObject's Bounds contains the Transform's position, output a message in the console
        if ((Collider.bounds.Contains(kwiatek)))
        {
            Debug.Log("Bounds contain the kwiatek");
        }
        
    }
}