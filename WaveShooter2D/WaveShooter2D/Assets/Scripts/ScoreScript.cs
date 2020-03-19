using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text displayText;
    private string textTodisplay;
    string scoreText = "Score: {0}";
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textTodisplay = string.Format(scoreText, PlayerController.score);

        displayText.text = textTodisplay;
    }
}
