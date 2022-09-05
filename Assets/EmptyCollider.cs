using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyCollider : MonoBehaviour
{
    public GameObject water;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Water"))
        {
            Instantiate(water, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
