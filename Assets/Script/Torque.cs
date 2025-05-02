using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class Torque : MonoBehaviour
{
    public float amount = 50f;

    Rigidbody rb;
    private void FixedUpdate()
    {
        rb = GetComponent<Rigidbody>();

        float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;
        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;



        rb.AddTorque(transform.up * h , ForceMode.VelocityChange);

        rb.AddTorque(transform.right * v , ForceMode.VelocityChange);


    }
}
