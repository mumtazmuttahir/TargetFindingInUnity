using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way1_DetectorObject_Collider : MonoBehaviour
{
    //Prerequisites
    //1. Both the colliding objects must have the collider components
    //2. At least of the colliding objects must have a Rigidbody component attached to it
    //3. isTrigger in the colliding object which this script is attached to, must by checked

    //Checks for the collision and calls this trigger event
    private void OnTriggerEnter(Collider other) {
        //If the tag of the colliding object is "Opponent" the true otherwise false
        if (other.tag == "Opponent")
        {
            Debug.Log("OnTriggerEnter Triggered by Enemy");
        }

        //bool Returns true if the component is found, false otherwise.
        //https://docs.unity3d.com/ScriptReference/Component.TryGetComponent.html
        //isTrigger must be off, for this event to work
        if(other.TryGetComponent<Opponent>(out Opponent opponent)) 
        {
            Debug.Log("TryGetComponent Triggered by Enemy");
        }

    }

    private void OnCollisionEnter(Collision other) {
        GameObject collidingObject = other.gameObject;
        Debug.Log ("OnCollisionEnter Target Found");
    }

}
