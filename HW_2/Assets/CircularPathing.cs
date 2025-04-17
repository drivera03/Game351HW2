using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularPathing : MonoBehaviour
{
    public Transform centerPoint; // The object around which the character orbits
    public float radius = 2f;       // The distance from the center
    public float speed = 1f;         // How quickly the character moves

    private float currentAngle = 0f;

    void Update()
    {
        // Increase the angle over time
        currentAngle += speed * Time.deltaTime;

        // Calculate the X and Z coordinates using trigonometry
        float x = centerPoint.position.x + Mathf.Cos(currentAngle) * radius;
        float z = centerPoint.position.z + Mathf.Sin(currentAngle) * radius;

        // Update the character's position
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
