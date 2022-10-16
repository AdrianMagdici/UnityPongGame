using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public float speed = 5f;
    PlayerControls controls;
    private void Awake()
    {
        controls = new PlayerControls();
        controls.Player.mouse.performed += ctx => Move();
    }
    private void OnEnable()
    {
        controls.Player.Enable();
    }
    private void OnDisable()
    {
        controls.Player.Disable();
    }
    private void Move()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        transform.position = new Vector3(-7.5f, Mathf.Clamp(speed * Time.fixedDeltaTime * mousePos.y, -3.91f, 3.91f));
    }
}
