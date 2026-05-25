using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtTimer;
    void Start()
    {

    }
    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }
    public void UpdateTimer(float time)
    {
        int tiempoEntero = (int)time;
        txtTimer.text = tiempoEntero.ToString();
    }
}