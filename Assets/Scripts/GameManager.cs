using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    private int player1Score;
    private int player2Score;
    [SerializeField] public TextMeshProUGUI player1ScoreText;
    [SerializeField] public TextMeshProUGUI player2ScoreText;

    public BallMovement ball;
   
    public void Player1Scores()
    {
        player1Score++;
        player1ScoreText.SetText(player1Score.ToString());
        this.ball.ResetBallPosition();
        Debug.Log("Player 1 scores");
    }

    public void Player2Scores()
    {
        player2Score++;
        player2ScoreText.SetText(player1Score.ToString());

        this.ball.ResetBallPosition();
        Debug.Log("Player 2 scores");

    }


}


