using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float controlSpeed = 25f;
    [SerializeField] float xRange = 10f;
    [SerializeField] float yRange = 5f;

    [SerializeField] float pitchFactor = 2f;

    float xThrow;
    float yThrow;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        MovingProcess();
        RotationProcess();
    }

    void MovingProcess()
    {
        xThrow = Input.GetAxis("Horizontal");
        yThrow = Input.GetAxis("Vertical");
        float offsetX = xThrow * Time.deltaTime * controlSpeed;
        float offsetY = yThrow * Time.deltaTime * controlSpeed;

        float rawX = transform.localPosition.x + offsetX;
        float rawY = transform.localPosition.y + offsetY;

        float newX = Mathf.Clamp(rawX, -xRange, xRange);
        float newY = Mathf.Clamp(rawY, -yRange, yRange);

        transform.localPosition = new Vector3(newX, newY, transform.localPosition.z);
    }

    void RotationProcess()
    {
        float pitch = transform.localPosition.y * pitchFactor + yThrow;
        float yaw = 0f;
        float roll = 0f;
        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }
}
