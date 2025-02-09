using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    Animator anim;

    public bool isBlending = false;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        isBlending = true;
        anim.SetBool("ButtonClicked", true);
    }

    private void OnMouseUp()
    {
        isBlending = false;
        anim.SetBool("ButtonClicked", false);
    }

    private void OnMouseExit()
    {
        isBlending = false;
        anim.SetBool("ButtonClicked", false);
    }
}
