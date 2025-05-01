using UnityEngine;

public class Cube_Physics : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(" collision detect");
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
