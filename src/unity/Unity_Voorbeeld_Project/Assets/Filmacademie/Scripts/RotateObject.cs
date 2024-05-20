using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Public variables to control rotation speed along each axis
    public float rotationSpeedX = 10f;
    public float rotationSpeedY = 10f;
    public float rotationSpeedZ = 10f;

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation for this frame
        float rotationX = rotationSpeedX * Time.deltaTime;
        float rotationY = rotationSpeedY * Time.deltaTime;
        float rotationZ = rotationSpeedZ * Time.deltaTime;

        // Apply the rotation to the transform
        transform.Rotate(rotationX, rotationY, rotationZ);
    }
}
