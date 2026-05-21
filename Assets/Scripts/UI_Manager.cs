using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }
}