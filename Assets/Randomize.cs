using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Randomize : MonoBehaviour
{
    float rand;
    public GameObject empty;
    public GameObject sand;
    public GameObject water;
    public GameObject villager;
    public GameObject seeds;
    public GameObject others;
    private void Start()
    {
        rand = Random.value;
        if (rand == 0)
        {
            empty.SetActive(true);
            empty.SetActive(false);
            empty.SetActive(false);
            empty.SetActive(false);
            empty.SetActive(false);
            empty.SetActive(false);
        }
    }
     void TileActive(string i)
    {
        //if (i == "sand")
    }
}
