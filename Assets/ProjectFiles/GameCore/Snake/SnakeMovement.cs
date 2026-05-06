using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 120f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
        rb.linearVelocity = transform.forward * speed;

        
        float h = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * h * turnSpeed * Time.fixedDeltaTime);
    }
}