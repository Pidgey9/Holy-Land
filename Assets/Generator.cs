using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject sand;
    int count;
    private void Start()
    {
        Instantiate(sand, transform.position,transform.rotation);
        count = 0;
    }
    private void LateUpdate()
    {
        if (count == 1000)
        {
            Destroy(gameObject);
        }
        count++;
    }
}
