using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogHealth : MonoBehaviour
{
    public bool isInsideBlender = false;

    public void TakeDamage()
    {
        print("Oh?");
        if (!isInsideBlender)
            return;

        print("Blend!");
    }

    public void InitialiseFrog()
    {
        FindObjectOfType<FrogBlend>().blend.AddListener(TakeDamage);
    }
}
