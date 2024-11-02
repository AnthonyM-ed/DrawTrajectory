using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : MonoBehaviour
{
    public int points = 1; // Puntos que este objeto otorgará
    private bool hasScored = false; // Verifica si el puntaje ya fue otorgado

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball") && !hasScored)
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(points);
                Debug.Log("Objetivo alcanzado: " + gameObject.name + ", puntos: " + points); // Log de colisión
            }
            else
            {
                Debug.LogError("ScoreManager no encontrado en la escena."); // Log de error si no se encuentra ScoreManager
            }

            hasScored = true;
        }
    }
}
