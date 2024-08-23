using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform donut;
    public TextMeshProUGUI scoreText;
    private float initialZPosition;

    void Start()
    {
        // Set the initial position on the Z-axis
        initialZPosition = 139.8652f;
    }

    void Update()
    {
        // Calculate the distance traveled from the initial position
        float distanceTraveled = initialZPosition - donut.position.z;

        // Update the score text with the distance traveled
        scoreText.text = distanceTraveled.ToString("0");
    }
}
