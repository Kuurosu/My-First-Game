using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    // We marked this with "Fixed"Update because
    // we are using it to mess with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 200 * Time.deltaTime); // add a force of 200 on the z-axis
    }
}
