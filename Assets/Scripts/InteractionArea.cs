using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public UI_Manager uiManagerScript;
    public int score = 0;
    void Awake()
    {
        uiManagerScript = GameObject.FindObjectOfType<UI_Manager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectible")){
            Destroy(other.gameObject);
            score ++;
            uiManagerScript.UpdateScore(score);
        }
    }
}
