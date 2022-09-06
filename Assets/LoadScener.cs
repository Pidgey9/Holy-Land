using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadScener : MonoBehaviour
{
    public Var level;
    TextMeshProUGUI text;
    public Var zombieNumber;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        text.text = level.value.ToString();
        if (zombieNumber.value <= 0)
        {
            SceneManager.LoadScene(1);
            level.value++;
        }
        if (level.value >= 10) SceneManager.LoadScene(3);
    }
}
