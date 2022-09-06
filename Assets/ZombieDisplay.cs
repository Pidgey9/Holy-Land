using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZombieDisplay : MonoBehaviour
{
    TextMeshProUGUI text;
    public Var number;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        text.text = number.value.ToString();
    }
}
