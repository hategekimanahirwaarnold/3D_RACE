using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    public float velocity = 10f;
    public float extreme = 7f;
    public float lastPosition = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
        // if ((rb.position.x > extreme && lastPosition < rb.position.x ) || (rb.position.x < -extreme && lastPosition > rb.position.x ))
        // {
        //     velocity = -velocity;
        //     Debug.Log("We are over the side. Last position: ");
        // }

        // lastPosition = rb.position.x;
        // rb.AddForce(velocity * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
           
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
