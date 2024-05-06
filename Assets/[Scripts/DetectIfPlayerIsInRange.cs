using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectIfPlayerIsInRange : MonoBehaviour
{
    [SerializeField]
    private GameObject playerReference = null;

    [Tooltip("How close the player has to be to activate this")]
    public float minimumRange;

    public bool isInRange = false;
    
    void Start()
    {
        playerReference = GameObject.FindGameObjectWithTag("Player");
        Debug.Assert(playerReference != null, "Add reference to player for script to work", this);
    }
    

    // Update is called once per frame
    void Update()
    {
        float currentDistanceFromPlayer = Vector3.Distance(playerReference.transform.position, transform.position);
        if (!(currentDistanceFromPlayer < minimumRange))
            return;

        isInRange = true;
    }


    public bool IsInRange()
    {
        return isInRange;
    }
}
