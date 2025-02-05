using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        anim.SetBool("ButtonClicked", true);
    }

    private void OnMouseUp()
    {
        anim.SetBool("ButtonClicked", false);
    }

    private void OnMouseExit()
    {
        anim.SetBool("ButtonClicked", false);
    }
}
