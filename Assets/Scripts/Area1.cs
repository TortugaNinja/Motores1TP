using UnityEngine;

public class Area1 : MonoBehaviour
{
    public void OnTriggerEnter()
    {
        GameManager player1Score = gameObject.GetComponent<GameManager>();
        player1Score.Player1Scores();
    }
}
