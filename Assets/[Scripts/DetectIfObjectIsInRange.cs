using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This Script Detects if a specific Object is in a specified range 
 */
public class DetectIfObjectIsInRange : MonoBehaviour
{
    [SerializeField] [Tooltip("This is the object to keep track of")]
    public GameObject objectToDetect;

   [Tooltip("How close the object needs to be considered in range")] 
    public float minimumDistanceFromObject = 1.5f;

    public bool isInRange = false;
    
    void Start()
    {
    }

    void Update()
    {
        float distanceFromObject = Vector3.Distance(objectToDetect.transform.position, transform.position);
        if (!(distanceFromObject < minimumDistanceFromObject))
        {
            isInRange = false;
            return;
        }

        isInRange = true;
    }

    public bool IsInRange()
    {
        return isInRange;
    }
}
