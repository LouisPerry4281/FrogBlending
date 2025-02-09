using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleanup : MonoBehaviour
{
    [SerializeField] float cleanupTime;

    private void Start()
    {
        Invoke(nameof(CleanupObject), cleanupTime);
    }

    private void CleanupObject()
    {
        Destroy(gameObject);
    }
}
