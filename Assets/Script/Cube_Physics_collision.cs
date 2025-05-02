using UnityEngine;

public class Cube_Physics_collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
                { 
            Debug.Log(" collision detect");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("collision happening ");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("no collision ");
    }
}
