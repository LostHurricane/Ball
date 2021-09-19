using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTurning : MonoBehaviour
{

    private float rotX = 0.0f; // rotation around the right/x axis
    private float rotY = 0.0f; // rotation around the up/y axis
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotations();
    }

    private void Rotations ()
    {
        //”правление вышло кривое переделаю на кнопки а мышь будет вращать камеру
        rotY += 90f * (Input.GetAxis("Mouse X")) * Time.deltaTime;
        rotX += 90f * (-Input.GetAxis("Mouse Y")) * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -50, 50);
        rotY = Mathf.Clamp(rotY, -50, 50);

        transform.rotation = Quaternion.Euler(rotX, 0f, rotY);
    }
}
