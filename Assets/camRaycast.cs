using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRaycast : MonoBehaviour
{
    public Camera cam;
    public GameObject empty;
    public GameObject sand;
    public Var zNumber;
    private void Update()
    {
        Ray ray = cam.ScreenPointToRay( Input.mousePosition );
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);
        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider.CompareTag("Sand"))
            {
                Destroy(hit.collider.gameObject);
                Instantiate(empty, hit.collider.transform.position, hit.collider.transform.rotation);
            }
            if (hit.collider.CompareTag("Empty"))
            {
                Destroy(hit.collider.gameObject);
                Instantiate(sand, hit.collider.transform.position, hit.collider.transform.rotation);
            }
            if (hit.collider.CompareTag("Villager"))
            {
                Destroy(hit.collider.gameObject);
                zNumber.value--;
            }
        }

    }
}
