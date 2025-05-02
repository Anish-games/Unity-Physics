using UnityEngine;

public class Cube_Physics_Trigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cube") || other.gameObject.CompareTag("floor"))
        {
            Debug.Log("Object entered the trigger: " + other.gameObject.name);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Object is within the trigger : " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object is exit the trigger : " + other.gameObject.name);
    }
}
