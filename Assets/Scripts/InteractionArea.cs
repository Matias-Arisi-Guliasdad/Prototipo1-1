using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameManager gameManagerScript;
    void Awake()
    {
        gameManagerScript = GameObject.FindObjectOfType<GameManager>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectible")){
            Destroy(other.gameObject);
            gameManagerScript.RegistrarMochila();
        }
    }
}
