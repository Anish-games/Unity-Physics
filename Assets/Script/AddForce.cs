using System;
using Unity.VisualScripting;
using UnityEngine;

public class AddForce : MonoBehaviour
{

    private void OnMouseDown()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.AddForce(- transform.forward * 500 , ForceMode.Acceleration);
        rb.useGravity = true;
    }

}
