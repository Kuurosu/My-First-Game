using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 800f;

    // We marked this with "Fixed"Update because
    // we are using it to mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add a force of 200 on the z-axis
    }
}
