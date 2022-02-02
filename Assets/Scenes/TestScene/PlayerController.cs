using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput _input;

    private void Awake()
    {
        TryGetComponent(out _input);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        _input.actions["Move"].performed += OnMovement;
        _input.actions["Move"].canceled += OnStop;
    }

    private void OnDisable()
    {
        _input.actions["Move"].performed -= OnMovement;
        _input.actions["Move"].canceled -= OnStop;
    }

    private void OnMovement(InputAction.CallbackContext obj)
    {
        var value = obj.ReadValue<Vector2>();
        var pos = transform.position;
        pos.x += value.x;
        pos.z += value.y;
        transform.position = pos;
    }

    void OnStop(InputAction.CallbackContext obj)
    {

    }
}
