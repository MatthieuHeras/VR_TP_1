using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube : MonoBehaviour
{
    public float force;
    private Rigidbody rb;
    private MeshRenderer mr;

    public GameObject otherCube;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(Vector3.right * -force * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * force * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mr.enabled = !mr.enabled;
        }

        mr.enabled = true;
        if (Vector3.Distance(otherCube.transform.position, transform.position) < 2)
            mr.enabled = false;

            
    }
}
