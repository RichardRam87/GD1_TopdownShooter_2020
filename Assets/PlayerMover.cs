using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");
        Vector3 inputDirection = new Vector3(xInput, 0f, zInput);
        inputDirection.Normalize();
              
        _characterController.Move(inputDirection * _speed * Time.deltaTime);
    }
}
