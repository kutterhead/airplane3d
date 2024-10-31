using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody body;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Debug.Log("Velocity: " + body.velocity.magnitude);
        if (Input.GetKey(KeyCode.U))
        {
            body.AddTorque(-transform.right * body.velocity.magnitude, ForceMode.Force);
            //transform.Rotate(-transform.right * body.velocity.magnitude * Time.deltaTime);
            print("Aplicando fuerzas de torque");

        }
        if (Input.GetKey(KeyCode.J))
        {
            body.AddTorque(transform.right * body.velocity.magnitude, ForceMode.Force);
            //transform.Rotate(transform.right * body.velocity.magnitude * Time.deltaTime);
            print("Aplicando fuerzas de torque");

        }
        if (Input.GetKey(KeyCode.N))
        {
            body.AddTorque(-transform.forward * body.velocity.magnitude, ForceMode.Force);
            //transform.Rotate(-transform.right * body.velocity.magnitude * Time.deltaTime);
            print("Aplicando fuerzas de torque");

        }
        if (Input.GetKey(KeyCode.M))
        {
            body.AddTorque(transform.forward * body.velocity.magnitude, ForceMode.Force);
            //transform.Rotate(transform.right * body.velocity.magnitude * Time.deltaTime);
            print("Aplicando fuerzas de torque");

        }
        body.AddForce(transform.forward * 100 * (Input.GetAxis("Vertical") + 0.1f), ForceMode.Force);
    }
}
