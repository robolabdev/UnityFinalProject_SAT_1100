using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSens = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    [SerializeField] FloatingJoystick _joystick;

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        var universalHorizontal = Input.GetAxis("Mouse X") + _joystick.Horizontal;
        var universalVertical = Input.GetAxis("Mouse Y") + _joystick.Vertical;
        float mouseX = universalHorizontal * mouseSens * Time.deltaTime;
        float mouseY = universalVertical * mouseSens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
