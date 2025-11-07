using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20f;
    public float tiltSpeed = 45f;
    private float verticalInput;

    void FixedUpdate()
    {
        // Get up/down key input (W/S or Up/Down arrows)
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward continuously
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Tilt only when user presses up/down
        transform.Rotate(Vector3.right * verticalInput * tiltSpeed * Time.deltaTime);
    }
}
