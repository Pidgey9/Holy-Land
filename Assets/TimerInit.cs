using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerInit : MonoBehaviour
{
    public Var timer;
    public Var level;
    private void Start()
    {
        timer.value = 0;
        level.value = 0;
    }
}
