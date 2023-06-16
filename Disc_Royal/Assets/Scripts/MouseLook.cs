using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100.0f;

    public bool freeLock = false;
    public Transform playerBody;

    private float xRotation = 0.0f;
    void Start()
    {
        // Lock the cursor so that it doesnt get in the way
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Set the mouse Axis
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        if(freeLock)
        {
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;


            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90.0f, 90.0f);
        }



        transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
