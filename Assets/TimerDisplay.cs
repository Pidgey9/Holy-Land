using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class TimerDisplay : MonoBehaviour
{
    TextMeshProUGUI text;
    public Var timer;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        int tvalue = Convert.ToInt32(timer.value);
        text.text = tvalue.ToString();
    }
}
