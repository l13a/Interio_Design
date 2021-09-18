using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScript : MonoBehaviour
{
    public Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        if (GUI.Button (new Rect(0, 0, 80, 20), "Up"))
        {
            rb.transform.Translate(Vector3.up * 3 * Time.deltaTime);
        }
        if (GUI.Button (new Rect(90, 0, 80, 20), "Down"))
        {
            rb.transform.Translate(Vector3.down * 3 * Time.deltaTime);
        }
        if (GUI.Button (new Rect(0, 30, 80, 20), "Left"))
        {
            rb.transform.Translate(Vector3.left * 3 * Time.deltaTime);
        }
        if (GUI.Button (new Rect(90, 30, 80, 20), "Right"))
        {
            rb.transform.Translate(Vector3.right * 3 * Time.deltaTime);
        }
        if (GUI.Button (new Rect(0, 60, 80, 20), "Forward"))
        {
            rb.transform.Translate(Vector3.forward * 3 * Time.deltaTime);
        }
        if (GUI.Button (new Rect(90, 60, 80, 20), "Backward"))
        {
            rb.transform.Translate(Vector3.back * 3 * Time.deltaTime);
        }
    }
    
}
