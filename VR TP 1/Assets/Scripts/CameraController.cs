using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x - Input.GetAxis("Mouse Y") * speed * Time.deltaTime, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
    }
}
