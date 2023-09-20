using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] InputAction movement;
    void Start()
    {
        
    }
    private void OnEnable()
    {
        movement.Enable();

    }

    private void OnDisable()
    {
        movement.Disable();
    }
    // Update is called once per frame
    void Update()
    {
        float horizon = movement.ReadValue<Vector2>().x;
        float verti = movement.ReadValue<Vector2>().y;

        /*float horizon = Input.GetAxis("Horizontal");*/
        Debug.Log("Horizontal value:" + horizon);

        /*float vertical = Input.GetAxis("Vertical");*/
        Debug.Log("Vertical value:" + verti);
    }
}
