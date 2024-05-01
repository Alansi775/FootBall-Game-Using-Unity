using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fbsConroll : MonoBehaviour
{
    public float speed = 5.0f;
    public float mousesensitivity = 100.0f;
    public float xrotation = 0.0f;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x, 0, y);

        float mouseX = Input.GetAxis("Mouse X") * mousesensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesensitivity * Time.deltaTime;

        xrotation -= mouseY;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);

        Camera.main.transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }

}