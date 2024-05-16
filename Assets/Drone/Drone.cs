using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public GameObject drone;
    
    public float upSpeed = 20.0f;
    public float forwSpeed;
    public float sideSpeed = 20.0f;
    public float turnSpeed = 1.0f;

    public float horizonInput;
    public float verticalInput;
    public float forwardInput;
    public float rotationHorInput;
    public float rotationForwInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        verticalInput = Input.GetAxis("Jump");
        horizonInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        rotationHorInput = Input.GetAxis("Horizontal2");
        rotationForwInput = Input.GetAxis("Vertical2");
        
        transform.Translate(Vector3.up * Time.deltaTime * verticalInput * upSpeed);
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * forwSpeed);
        transform.Translate(Vector3.right * Time.deltaTime * horizonInput * sideSpeed);
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationHorInput * turnSpeed);
        transform.Rotate(Vector3.right * Time.deltaTime * rotationForwInput * turnSpeed);

        if(transform.position.y < 5.0f)
        {
            forwSpeed = 0.0f;

        }
        else
        {
            forwSpeed = 20.0f;

        }

    
    }
}
