using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed;
    public float rotationSpeed;

    private Vector2 movementValue;
    private float lookValue;


    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
  
    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }
    
    public void OnLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        // 새로운 Input System에서 마우스 오른쪽 버튼 입력 가져오기
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            speed *= 3;
        }

        if (Mouse.current.rightButton.wasReleasedThisFrame)
        {
            speed /= 3;
        }

        transform.Translate(
            movementValue.x * Time.deltaTime, 0, movementValue.y * Time.deltaTime);
        transform.Rotate(0, lookValue * Time.deltaTime, 0);

       
    }

    


 
}
