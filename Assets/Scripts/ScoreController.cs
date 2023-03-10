using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public int goalToWin;

    // Update is called once per frame
    void Update()
    {
        if (this.scorePlayer1 >= this.goalToWin || this.scorePlayer2 >= this.goalToWin)
        {
            Debug.Log("Game won");
            SceneManager.LoadScene("GameOver");
        }

}

    private void FixedUpdate()
    {
        TextMeshProUGUI uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<TextMeshProUGUI>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();
        
        TextMeshProUGUI uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<TextMeshProUGUI>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {
        Debug.Log("Player 1 scored");
        this.scorePlayer1++;
    }

    public void GoalPlayer2()
    {        
        Debug.Log("Player 2 scored");
        this.scorePlayer2++;
    }
}
