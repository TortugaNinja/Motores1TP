using UnityEngine;

public class Area2 : MonoBehaviour
{
    public void OnTriggerEnter()
    {
        GameManager player2Score = gameObject.GetComponent<GameManager>();
        player2Score.Player1Scores();
    }
}
