using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane3d : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;

    public float potenciaMotor = 100f;

    public float roll = 10f;
    public float pitch = 10f;
    public float yaw = 10f;
    public float Vmax = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadZ = rb.velocity.magnitude;
        print(velocidadZ);

        if (velocidadZ< Vmax)
        {
            rb.AddForce(transform.forward * potenciaMotor , ForceMode.Force);
        }
        //rb.AddForce(transform.forward * potenciaMotor * Input.GetAxis("Vertical"), ForceMode.Force);

        if (velocidadZ > Vmax/2)//esta es la velocidad de despegue
        {
            rb.AddForce(transform.forward * potenciaMotor, ForceMode.Force);
            rb.AddTorque(transform.forward * velocidadZ * -Input.GetAxis("Horizontal") * roll, ForceMode.Force);
            rb.AddTorque(transform.up * velocidadZ * Input.GetAxis("Horizontal") * yaw, ForceMode.Force);


            rb.AddTorque(transform.right * velocidadZ * Input.GetAxis("Vertical") * pitch, ForceMode.Force);
        }




    }
}
