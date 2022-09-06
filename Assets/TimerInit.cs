using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerInit : MonoBehaviour
{
    public Var timer;
    private void Start()
    {
        timer.value = 0;
    }
}
