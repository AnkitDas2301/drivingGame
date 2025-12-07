using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This variable will control the speed of the vehicle
    [SerializeField] private float speed = 11.0f;
    private readonly float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey = KeyCode.C;

    public string inputID;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
