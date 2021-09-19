using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Canvas canvas;
    public bool toggle = false;

    public void popUp()
    {
        if (toggle == false) {
            toggle = true;
            canvas.enabled = true;
        }
        else
        {
            toggle = false;
            canvas.enabled = false;

        }
    }
}
