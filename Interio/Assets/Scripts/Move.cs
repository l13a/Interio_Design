using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Move : MonoBehaviour
{
    public static Rigidbody rb;

    public static void moveCube()
    {
        rb.transform.Translate(Vector3.up * Time.deltaTime);
    }
}
