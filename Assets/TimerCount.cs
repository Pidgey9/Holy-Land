using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCount : MonoBehaviour
{
    public Var timer;
    private void Update()
    {
        timer.value += Time.deltaTime;
    }
}
