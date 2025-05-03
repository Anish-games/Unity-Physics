using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float deplomentHight;
    private void Update()
    {
        RaycastHit Hit;

        Ray ladingray = new Ray(transform.position,Vector3.down);

        Debug.DrawRay(transform.position, Vector3.down * deplomentHight);

        if (Physics.Raycast(ladingray, out Hit, deplomentHight))
        {
            Debug.Log("its hit");
        }
    }

}
