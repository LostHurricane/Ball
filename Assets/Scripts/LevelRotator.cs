using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotator //: MonoBehaviour
{
    private int turningSpeed = 2;
    private float maxRotationSpeed = 6;

    private float cumulativeMouseInputX = 0.0f; // rotation around the right/x axis
    private float cumulativeMouseInputY = 0.0f; // rotation around the up/y axis
    private float maxCumulativeMouseInput = 1.5f;

    private float rotX = 0.0f; // rotation around the right/x axis
    private float rotY = 0.0f; // rotation around the up/y axis
    private float maxAngle = 20;

    private Transform level;

    

    public LevelRotator(Transform level)
    {
        this.level = level;
    }

    public void Rotate(float inputMouseX, float inputMouseY)
    {
        //Debug.LogError(inputMouseX);
        //Debug.LogError(inputMouseY);

        cumulativeMouseInputX = Mathf.Clamp(cumulativeMouseInputX + inputMouseX, -maxCumulativeMouseInput, maxCumulativeMouseInput);
        cumulativeMouseInputY = Mathf.Clamp(cumulativeMouseInputY + inputMouseY, -maxCumulativeMouseInput, maxCumulativeMouseInput);

        rotY += Mathf.Clamp(turningSpeed * (cumulativeMouseInputX) * Time.deltaTime, -maxRotationSpeed, maxRotationSpeed);
        rotX += Mathf.Clamp(turningSpeed * (cumulativeMouseInputY) * Time.deltaTime, -maxRotationSpeed, maxRotationSpeed);

        level.rotation = Quaternion.Euler(Mathf.Clamp(rotX, -maxAngle, maxAngle), 0f, Mathf.Clamp (rotY, -maxAngle, maxAngle));
    }

}
