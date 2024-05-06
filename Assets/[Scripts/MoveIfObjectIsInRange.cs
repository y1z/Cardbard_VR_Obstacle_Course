using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIfObjectIsInRange : MonoBehaviour
{
    private DetectIfObjectIsInRange _isObjectInRange;

    [SerializeField]
    private GameObject objectToDetect;

    [SerializeField]
    private Vector3 whereToMoveTo = Vector3.left * 1337.0f;

    public float range = 1.5f;
    void Start()
    {
        Debug.Assert(objectToDetect != null, "Please assign a GameObject to objectToDetect", this);
        _isObjectInRange = gameObject.AddComponent<DetectIfObjectIsInRange>();
        _isObjectInRange.objectToDetect = objectToDetect;
        _isObjectInRange.minimumDistanceFromObject = range;

    }

    // Update is called once per frame
    void Update()
    {
        if (!_isObjectInRange.IsInRange())
        {
            return;
        }

        transform.position = whereToMoveTo;
    }
}
