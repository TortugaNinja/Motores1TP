using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [Header("Paddle Movement")]
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private KeyCode keyUp = KeyCode.W;
    [SerializeField] private KeyCode keyDown = KeyCode.S;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigidbody = GetComponent<Rigidbody2D>();
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
        float deltaTimeRegulation = Time.deltaTime * 100;

        if (Input.GetKey(keyUp))
        {
            rigidbody.AddForce(Vector2.up * deltaTimeRegulation * speed, ForceMode2D.Impulse);
            Debug.Log("keyUp");
        }

        if (Input.GetKey(keyDown))
        {
            rigidbody.AddForce(Vector2.down * deltaTimeRegulation * speed, ForceMode2D.Impulse);
            Debug.Log("keyDown");
        }

    }
}
