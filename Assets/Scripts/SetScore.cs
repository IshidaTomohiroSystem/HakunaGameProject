using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetScore : MonoBehaviour
{
    [SerializeField] ScoreData scoreData;
    [SerializeField] TextMeshProUGUI textMeshPro;
    int score = 0;

    // Update is called once per frame
    void Update()
    {
        if (scoreData.score == score)
            return;
        textMeshPro.text = scoreData.score.ToString();
        score= scoreData.score;
    }
}
