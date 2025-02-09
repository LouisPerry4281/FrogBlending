using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.TryGetComponent<FrogHealth>(out FrogHealth frog))
        {
            frog.isInsideBlender = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<FrogHealth>(out FrogHealth frog))
        {
            frog.isInsideBlender = false;
        }
    }
}
