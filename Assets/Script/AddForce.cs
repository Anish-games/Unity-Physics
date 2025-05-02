using System;
using Unity.VisualScripting;
using UnityEngine;

public class AddForce : MonoBehaviour
{

    private void OnMouseDown()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.AddForce(- transform.forward * 500);
        rb.useGravity = true;
    }

}
