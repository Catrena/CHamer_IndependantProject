using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneMovement : MonoBehaviour
{
    //rate of forwrd/backward movement
    public float speed = 15.0f;
    public float turnSpeed = 15.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

               // Vector3.forward -- > (0, 0, 1)
        //(0, 0, 1) * Time.deltaTime * (0, 0, .016) * * (0, 0, .16)
        transform.Translate(Vector3.down * Time.deltaTime * speed);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalinput);
        //transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }
}
