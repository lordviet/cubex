using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float slideForce = 500f; 
    
    // FixedUpdate for physics 
    // Time.deltaTime is used for optimized fps 
	void FixedUpdate ()
    {
        // forwardForce added in the place of Z 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            rb.AddForce(slideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //Only executed if a condition is met 
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-slideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            //Only executed if a condition is met 
        }

        if (rb.position.y < 1f)
        {
            FindObjectOfType<GameManager2>().EndGame();
        }


    } 

}
