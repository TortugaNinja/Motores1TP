using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallMovement : MonoBehaviour

{
    
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D ball;
    public GameManager gameManager;

    [Header("Ball Speed")]
    [SerializeField] float ballSpeed = 10f;


    private void Awake()
    {
       

    }
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        GiveInitialForce();
    }
    private void GiveInitialForce()
    {
        float deltaTimeRegulation = Time.deltaTime * 1000;
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5 ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        if (Input.GetKey(KeyCode.Space) && ball.position.Equals(Vector3.zero))
        {
            ball.AddForce(this.ballSpeed * deltaTimeRegulation * direction);
        }
    }

    public float GetBallMovementSpeed()
    {
        return ballSpeed;
    }

    public void SetBallMovementSpeed(float newBallSpeed)
    {
        ballSpeed = newBallSpeed;
    }

    public void GiveForcePowerUp(Vector2 force)
    {
        ball.AddForce(force);
    }

    public void ResetBallPosition()
    {
        ball.position = Vector3.zero;
        ball.velocity = Vector3.zero;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score1"))
        {
            Debug.Log("Score1");
            gameManager.Player1Scores();
        }
        else if (collision.gameObject.CompareTag("Score2"))
        {
            Debug.Log("Score2");
            gameManager.Player2Scores();
        }

    }
}
