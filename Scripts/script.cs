using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float speed=15f;
    public float mousesen = 150f;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public CharacterController controller;
     
    void Start()
    {
     
    }
    void Update()
    {
        yaw += mousesen * Input.GetAxis("Mouse X")*Time.deltaTime;
        pitch -= mousesen * Input.GetAxis("Mouse Y")*Time.deltaTime;
        pitch = Mathf.Clamp(pitch, -90f, 90f);
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        float x = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        float z = Input.GetAxis("Vertical")* speed * Time.deltaTime;
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move);
    }
}
