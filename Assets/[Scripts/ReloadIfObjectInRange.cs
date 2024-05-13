using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadIfObjectInRange : MonoBehaviour
{
    private DetectIfPlayerIsInRange _isInRangeScript;

    public float Range = 1.5f;

    private bool isLoading = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _isInRangeScript = gameObject.AddComponent<DetectIfPlayerIsInRange>();
        _isInRangeScript.minimumRange = Range;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isInRangeScript.IsInRange() && !isLoading)
            return;

        String name = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(name);
        isLoading = true;
    }
}
