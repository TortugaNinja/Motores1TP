using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [Header("Paddle Movement")]
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private KeyCode keyUp = KeyCode.W;
    [SerializeField] private KeyCode keyDown = KeyCode.S;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D paddle;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        paddle = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    public float GetMovementSpeed()
    {
        return speed;
    }

    public void SetMovementSpeed(float newSpeed)
    {
        if (newSpeed < 0.5f)
        {
            speed = newSpeed;
        }
    }
    private void Move()
    {
        Vector3 position = transform.position;
        float deltaTimeRegulation = Time.deltaTime * 100;

        if (Input.GetKey(keyUp))
        {
            position.y += speed * deltaTimeRegulation;
            Debug.Log("keyUp");
        }

        if (Input.GetKey(keyDown))
        {
            position.y -= speed * deltaTimeRegulation;
            Debug.Log("keyDown");
        }

        transform.position = position;
    }
}
