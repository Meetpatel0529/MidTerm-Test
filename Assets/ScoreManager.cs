using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;  // Store the player's score

    // Method to increase the score
    public void AddScore(int points)
    {
        score += points;  // Add points to the score
        PrintScore();  // Print the updated score to the console
    }

    // Method to print the score to the console
    private void PrintScore()
    {
        Debug.Log("Score: " + score);  // Print score in the console
    }
}
