using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class HoverPad : MonoBehaviour
{

    public float hoverForce = 12f;

    void OnTriggerStay(Collider other)
    { 
       Rigidbody rb = other.GetComponent<Rigidbody>(); // Preferred way to access Rigidbody
        if (rb != null)
        {
            rb.AddForce(Vector3.up * hoverForce, ForceMode.Acceleration);
        }
    }
}
