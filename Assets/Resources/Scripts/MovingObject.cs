using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    [SerializeField] private bool reverseMove = false;
    [SerializeField] private Transform objectToUse;
    [SerializeField] private bool moveThisObject = false;
    private float startTime;
    private float journeyLength;
    private float distCovered;
    private float fracJourney;

    // Start is called before the first frame update
    void Start()
    {
        //Start Time of the object to move, when the script activates
        startTime = Time.time;

        //If the bool is true
        if (moveThisObject)
        {
            objectToUse = transform;
        }

        //Calculate the 3D distance between the 2 points
        journeyLength = Vector3.Distance(pointA.transform.position, pointB.transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculates the distance covered from the start time to the current time
        distCovered = (Time.time - startTime) * moveSpeed;
        //Gets the fraction of the journey
        fracJourney = distCovered / journeyLength;

        //If the object is moving back from Point B to Point A
        if (reverseMove)
        {
            objectToUse.position = Vector3.Lerp(pointB.transform.position, pointA.transform.position, fracJourney);
        }
        else
        {
            objectToUse.position = Vector3.Lerp(pointA.transform.position, pointB.transform.position, fracJourney);
        }
        //If the distance between the object and either of the points is 0
        if ((Vector3.Distance(objectToUse.position, pointB.transform.position) == 0.0f || Vector3.Distance(objectToUse.position, pointA.transform.position) == 0.0f)) //Checks if the object has travelled to one of the points
        {
            //Toggle bool value
            if (reverseMove)
            {
                reverseMove = false;
            }
            else
            {
                reverseMove = true;
            }
            //Star the timer again
            startTime = Time.time;
        }
        
    }
}
