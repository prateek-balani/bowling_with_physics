
using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed = 10f;
    private Rigidbody rb;

    private void Start()
    {
        inputManager.OnMove.AddListener(MovePlayer);
        rb = GetComponent<Rigidbody>();

    }

    private void MovePlayer(Vector2 direction)
    {
        Vector3 moveDirection = new (direction.x, 0f, 0f) ;
        rb.AddForce(speed*moveDirection);
    }

}