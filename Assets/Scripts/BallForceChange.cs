using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForceChange : MonoBehaviour
{
    [Header("Bounce Extra Power")]
    [SerializeField] private float bouncePower;
    
    public void OnCollisionEnter2D(Collision2D collision)
    {

        BallMovement ball = collision.gameObject.GetComponent<BallMovement>();
        float deltaTimeRegulation = Time.deltaTime * 100;

        if (ball != null)
        {
            Vector2 bounceAngle = collision.GetContact(0).normal;
            ball.GiveForcePowerUp(bouncePower * deltaTimeRegulation * -bounceAngle);
        }

    }
}
