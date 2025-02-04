using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FrogBlend : MonoBehaviour
{
    public UnityEvent blend;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BlendFrog();
        } 
    }

    private void BlendFrog()
    {
        blend.Invoke();
    }
}
