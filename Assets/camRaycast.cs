using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRaycast : MonoBehaviour
{
    public Camera cam;
    private void FixedUpdate()
    {
        Ray ray = cam.ScreenPointToRay( Input.mousePosition );
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
        if (hit.collider != null)
        {

        }
    }
}
