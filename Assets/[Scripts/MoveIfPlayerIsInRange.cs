using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script moves the attached object to the specified location when the player is in range
 */
public class MoveIfPlayerIsInRange : MonoBehaviour
{
    private DetectIfPlayerIsInRange _isInRangeScript;
    
    [Tooltip("This is were the object will moved to")]
    [SerializeField] Transform _whereToMove = null;

    public float Range = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        _isInRangeScript = gameObject.AddComponent<DetectIfPlayerIsInRange>();
        _isInRangeScript.minimumRange = Range;
        //  
        if (_whereToMove == null)
        {
            _whereToMove = gameObject.AddComponent<Transform>();
            _whereToMove.position = Vector3.left * 1337.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isInRangeScript.IsInRange())
            return;

        Debug.Log("Current position = " + transform.position  );
        transform.position = _whereToMove.position;
        
        Debug.Log("After switch =" + transform.position  );
    }
}
