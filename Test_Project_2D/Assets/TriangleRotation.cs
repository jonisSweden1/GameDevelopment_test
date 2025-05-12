using UnityEngine;

public class TriangleRotation : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 10f; // Speed of rotation in degrees per second

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * rotationSpeed);
    }
}
