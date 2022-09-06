using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReward : MonoBehaviour
{
    public GameObject textScore;
    public GameObject score;
    public GameObject reward;
    public GameObject button;
    public GameObject blood;
    public void Reward()
    {
        reward.SetActive(false);
        button.SetActive(false);
        textScore.SetActive(true);
        score.SetActive(true);
        blood.SetActive(true);
    }
}
