using UnityEngine;

namespace clase1
{
    public class Movement : MonoBehaviour
    {
        [Header("Movement")]
        public float speed = 0.1f;
        [SerializeField] private KeyCode keyUp = KeyCode.W;
        [SerializeField] private KeyCode keyDown = KeyCode.S;
        [SerializeField] private KeyCode keyLeft = KeyCode.A;
        [SerializeField] private KeyCode keyRight = KeyCode.D;

        [Header("Rotation")]
        public float rotation = 10f;
        [SerializeField] private KeyCode rotationAntiHourLike = KeyCode.Q;
        [SerializeField] private KeyCode rotationHourLike = KeyCode.E;

        [Header("Colour Change")]
        [SerializeField] private KeyCode colourChange = KeyCode.R;

        private SpriteRenderer spriteRenderer;


        private void Awake()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }



        void Update()
        {
            Move();
            Rotate();
            ChangeColour();
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

        public float GetRotationAngle()
        {
            return rotation;
        }

        public void SetRotationAngle(float newRotationAngle)
        {
            if (newRotationAngle < 360f)
            {
                rotation = newRotationAngle;
            }
            else
            {
                rotation = 0f;
            }
        }



        private void Move()
        {
            Vector3 position = transform.position;
            var deltaTimeRegulation = Time.deltaTime * 100;

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

            if (Input.GetKey(keyLeft))
            {
                position.x -= speed * deltaTimeRegulation;
                Debug.Log("keyLeft");
            }

            if (Input.GetKey(keyRight))
            {
                position.x += speed * deltaTimeRegulation;
                Debug.Log("keyRight");
            }

            transform.position = position;
        }

        private void Rotate()
        {
            var rotationAntiHour = Time.deltaTime * rotation;
            var rotationHour = Time.deltaTime * -rotation;

            if (Input.GetKeyDown(rotationHourLike) || Input.GetKey(rotationHourLike))
            {
                transform.Rotate(new Vector3(0, 0, rotationHour));
            }
            if (Input.GetKeyDown(rotationAntiHourLike) || Input.GetKey(rotationAntiHourLike))
            {
                transform.Rotate(new Vector3(0, 0, rotationAntiHour));
            }
        }

        private void ChangeColour()
        {
            if (Input.GetKeyDown(colourChange) || Input.GetKey(colourChange))
            {
                GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            }
        }
    }
}
