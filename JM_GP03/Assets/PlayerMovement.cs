using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){ transform.Translate(0, 0, speed); }
        if (Input.GetKey(KeyCode.S)){ transform.Translate(0, 0, -speed); }
        if (Input.GetKey(KeyCode.A)){ transform.Translate(-speed, 0, 0); }
        if (Input.GetKey(KeyCode.D)){ transform.Translate(speed, 0, 0); }

        float mouseX = Input.GetAxis("Mouse X");
        //float mouseY = Input.GetMouseButtonUp(2);
        transform.Rotate(0, mouseX * rotationSpeed, 0);
        
    }
}
