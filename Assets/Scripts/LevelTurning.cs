using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTurning : MonoBehaviour
{
    [SerializeField]
    private float rotXmax = 40f;
    [SerializeField]
    private float rotYmax = 40f;

    private float rotX = 0.0f; // rotation around the right/x axis
    private float rotY = 0.0f; // rotation around the up/y axis

    public Transform levelToRotate;
    LevelRotator LR;

    private void Awake()
    {
        //levelToRotate = GameObject.GetComponent<Transform>();
        LR = new LevelRotator(levelToRotate);
    }

    // Update is called once per frame
    void Update()
    {
        LR.Rotate(Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y"));
        //Rotations();
        //Debug.LogError(Input.GetAxis("Mouse X"));
        
    }

    private void Rotations ()
    {
        //”правление вышло кривое переделаю на кнопки а мышь будет вращать камеру
        rotY += 90f * (Input.GetAxis("Mouse X")) * Time.deltaTime;
        rotX += 90f * (-Input.GetAxis("Mouse Y")) * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -rotXmax, rotXmax);
        rotY = Mathf.Clamp(rotY, -rotYmax, rotYmax);
        

        transform.rotation = Quaternion.Euler(rotX, 0f, rotY);
    }
}
