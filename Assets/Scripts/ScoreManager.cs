using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0; // Variable que almacena el puntaje
    public TextMeshProUGUI scoreText; // Referencia al componente de texto para mostrar el puntaje

    // Método para aumentar el puntaje
    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Puntos: " + score);
        UpdateScoreText();
    }

    // Actualizar el texto en pantalla
    void UpdateScoreText()
    {
        scoreText.text = "Puntaje: " + score.ToString();
    }
}
