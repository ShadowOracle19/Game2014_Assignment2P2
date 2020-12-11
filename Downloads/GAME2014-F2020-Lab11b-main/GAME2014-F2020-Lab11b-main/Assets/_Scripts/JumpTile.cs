using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTile : MonoBehaviour
{
    public PlayerBehaviour playerBehaviour;
    public float verticalForce = 1500;
    public float LaunchHeight = 2000;
    private void OnCollisionEnter(Collision collision)
    {

    }
    private void OnCollisionExit(Collision collision)
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerBehaviour.m_rigidBody2D.AddForce(Vector2.right * verticalForce);
        playerBehaviour.m_rigidBody2D.AddForce(Vector2.up * LaunchHeight);
    }
    
}
