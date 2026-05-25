using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UI_Manager uiManagerScript;
    int score = 0;
    public int scoreMaximo;
    public float tiempoRestante = 30f;
    bool JuegoTerminado = false;
    void Awake()
    {
        uiManagerScript = GameObject.FindObjectOfType<UI_Manager>();
    }

    void Update()
    {
        if (JuegoTerminado) return;

        tiempoRestante -= Time.deltaTime;
        uiManagerScript.UpdateTimer(tiempoRestante);

        if (tiempoRestante <= 0)
        {
            tiempoRestante = 0; 
            JuegoTerminado = true; 
            Debug.Log("Loss");     
        }
    }
    
    public void RegistrarMochila()
    {
       score++;
       uiManagerScript.UpdateScore(score);
       if (score >= scoreMaximo)
        {
            JuegoTerminado = true; 
            Debug.Log("Win");      
        }
    }
}
